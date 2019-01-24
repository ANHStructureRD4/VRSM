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
    public class BaseListDataStore : IBaseListDataStore
    {
        #region Protected Members

        /// <summary>
        /// The database context for the client data store
        /// </summary>
        protected BaseDbContext mDbContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="dbContext">The database to use</param>
        public BaseListDataStore(BaseDbContext dbContext)
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
            return await GetCompositeListsAsync() != null;
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
        public Task<List<CompositeDataModel>> GetCompositeListsAsync()
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

            return Task.FromResult(mDbContext.Composite.FromSql("GetCompositeList @Name, @Content", param).ToList());
        }

        public Task<CompositeDataModel> GetCompositeListItemsAsync(string name)
        {
            // Get the first column in the login credentials table, or null if none exist
            return Task.FromResult(mDbContext.Composite.Where(b => b.Name.Contains(name)).FirstOrDefault());
        }

        /// <summary>
        /// Stores the given login credentials to the backing data store
        /// </summary>
        /// <param name="loginCredentials">The login credentials to save</param>
        /// <returns>Returns a task that will finish once the save is complete</returns>
        public async Task SaveBaseListsAsync(CompositeDataModel baseLists)
        {
            // Clear all entries
            mDbContext.Composite.RemoveRange(mDbContext.Composite);

            // Add new one
            mDbContext.Composite.Add(baseLists);

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
            mDbContext.Composite.RemoveRange(mDbContext.Composite);

            // Save changes
            await mDbContext.SaveChangesAsync();
        }

        #endregion
    }
}
