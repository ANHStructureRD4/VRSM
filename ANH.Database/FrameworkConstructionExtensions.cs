using ANH.Core;
using Dna;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ANH.Database
{
    /// <summary>
    /// Extension methods for the <see cref="FrameworkConstruction"/>
    /// </summary>
    public static class FrameworkConstructionExtensions
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public static FrameworkConstruction AddClientDataStore(this FrameworkConstruction construction)
        {
            // The service of frameworkcontruction
            var service = construction.Services;

            // Inject our SQLite EF data store
            service.AddDbContext<ClientDataStoreDbContext>(options =>
            {
                // Setup connection string
                options.UseSqlite(construction.Configuration.GetConnectionString("SQLiteDataStoreConnection"));
                //options.UseSqlServer(construction.Configuration.GetConnectionString("MsSqlDataStoreConnection"));
            }, contextLifetime: ServiceLifetime.Transient);

            service.AddDbContext<BaseDbContext>(options =>
            {
                // Setup connection string
                //options.UseSqlite(construction.Configuration.GetConnectionString("SQLiteDataStoreConnection"));
                options.UseSqlServer(construction.Configuration.GetConnectionString("MsSqlDataStoreConnection"));
            }, contextLifetime: ServiceLifetime.Transient);

            // Add client data store for easy access/use of the backing data store
            // Make it scoped so we can inject the scoped DbContext
            service.AddTransient<IClientDataStore>(
                provider => new BaseClientDataStore(provider.GetService<ClientDataStoreDbContext>()));

            // Add client data store for easy access/use of the backing data store
            // Make it scoped so we can inject the scoped DbContext
            service.AddTransient<IBaseListDataStore>(
                provider => new BaseListDataStore(provider.GetService<BaseDbContext>()));

            // Return framework for chaining
            return construction;
        }
    }
}
