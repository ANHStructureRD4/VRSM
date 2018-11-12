using ANH.Core;
using Microsoft.EntityFrameworkCore;

namespace ANH.Database
{
    /// <summary>
    /// The database context for the client data store
    /// </summary>
    public class BaseListDataDbContext : DbContext
    {
        #region DbSets 

        /// <summary>
        /// The client login credentials
        /// </summary>
        public DbSet<BaseListItemDataModel> BaseListItems { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseListDataDbContext(DbContextOptions<BaseListDataDbContext> options) : base(options) { }

        #endregion

        #region Model Creating

        /// <summary>
        /// Configures the database structure and relationships
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fluent API

            // Configure LoginCredentials
            // --------------------------
            //
            // Set Id as primary key
            modelBuilder.Entity<BaseListItemDataModel>().HasKey(a => a.Name);

            // Set up limits
            //modelBuilder.Entity<BaseListItemDataModel>().Property(a => a.FirstName).HasMaxLength(50);
        }

        #endregion
    }
}
