using ANH.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ANH.Database
{
    /// <summary>
    /// Stores and retrieves information about the client application 
    /// such as login credentials, messages, settings and so on
    /// in an SQLite database
    /// </summary>
    public class MaterialListDataStore : IMaterialListDataStore
    {
        #region Protected Members

        /// <summary>
        /// The database context for the client data store
        /// </summary>
        protected MaterialDbContext mDbContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="dbContext">The database to use</param>
        public MaterialListDataStore(MaterialDbContext dbContext)
        {
            // Set local member
            mDbContext = dbContext;
        }

        #endregion

        #region Interface Implementation

        /// <summary>
        /// Determines if the current lists has some data
        /// </summary>
        public async Task<bool> HasListsAsync()
        {
            return await GetMaterialListsAsync() != null;
        }

        /// <summary>
        /// Makes sure the client data store is correctly set up
        /// </summary>
        /// <returns>Returns a task that will finish once setup is complete</returns>
        public async Task EnsureDataStoreAsync()
        {
            // Make sure the database exists and is created
            await mDbContext.Database.EnsureCreatedAsync();
        }

        /// <summary>
        /// Gets the stored login credentials for this client
        /// </summary>
        /// <returns>Returns the login credentials if they exist, or null if none exist</returns>
        public Task<List<MaterialDataModel>> GetMaterialListsAsync()
        {
            // Get the first column in the login credentials table, or null if none exist
            //return Task.FromResult(mDbContext.Composite.ToList());

            var param = new[]
            {
                new SqlParameter("@Name", "Composite3"),
                new SqlParameter("@Content", ""),
            };
            //var param2 = new SqlParameter("content", "");

            //sqlParameter.Add(param1);

            return Task.FromResult(mDbContext.Material.FromSql("GetCompositeList @Name, @Content", param).ToList());
        }

        public Task<MaterialDataModel> GetMaterialListItemsAsync(string name)
        {
            // Get the first column in the login credentials table, or null if none exist
            return Task.FromResult(mDbContext.Material.Where(b => b.Name.Contains(name)).FirstOrDefault());
        }

        /// <summary>
        /// Stores the given login credentials to the backing data store
        /// </summary>
        /// <param name="loginCredentials">The login credentials to save</param>
        /// <returns>Returns a task that will finish once the save is complete</returns>
        public async Task SaveBaseListsAsync(MaterialDataModel baseLists)
        {
            // Clear all entries
            mDbContext.Material.RemoveRange(mDbContext.Material);

            // Add new one
            mDbContext.Material.Add(baseLists);

            // Save changes
            await mDbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Removes all login credentials stored in the data store
        /// </summary>
        /// <returns></returns>
        public async Task ClearAllBaseListsAsync()
        {
            // Clear all entries
            mDbContext.Material.RemoveRange(mDbContext.Material);

            // Save changes
            await mDbContext.SaveChangesAsync();
        }

        #endregion
    }
}
