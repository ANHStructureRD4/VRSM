using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ANH.Database
{
    /// <summary>
    /// Stores and retrieves information about the client application 
    /// such as login credentials, messages, settings and so on
    /// </summary>
    public interface IMaterialListDataStore
    {
        /// <summary>
        /// Determines if the current lists has some data
        /// </summary>
        Task<bool> HasListsAsync();

        /// <summary>
        /// Makes sure the client data store is correctly set up
        /// </summary>
        /// <returns>Returns a task that will finish once setup is complete</returns>
        Task EnsureDataStoreAsync();

        /// <summary>
        /// Gets the stored login credentials for this client
        /// </summary>
        /// <returns>Returns the login credentials if they exist, or null if none exist</returns>
        Task<List<MaterialDataModel>> GetMaterialListsAsync();

        Task<MaterialDataModel> GetMaterialListItemsAsync(string name);

        /// <summary>
        /// Stores the given login credentials to the backing data store
        /// </summary>
        /// <param name="loginCredentials">The login credentials to save</param>
        /// <returns>Returns a task that will finish once the save is complete</returns>
        Task SaveBaseListsAsync(MaterialDataModel baseLists);

        /// <summary>
        /// Removes all login credentials stored in the data store
        /// </summary>
        /// <returns></returns>
        Task ClearAllBaseListsAsync();
    }
}
