using Microsoft.AspNetCore.Identity;

namespace ANH.Web.Server
{
    /// <summary>
    /// The user data and profile for our application
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// The Users first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The Users last name
        /// </summary>
        public string LastName { get; set; }
    }
}
