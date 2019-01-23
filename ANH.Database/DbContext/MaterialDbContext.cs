using ANH.Core;
using Microsoft.EntityFrameworkCore;

namespace ANH.Database
{
    /// <summary>
    /// The database context for the client data store
    /// </summary>
    public class MaterialDbContext : DbContext
    {
        #region DbSets 

        /// <summary>
        /// The client login credentials
        /// </summary>
        public DbSet<MaterialDataModel> Material { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MaterialDbContext(DbContextOptions<MaterialDbContext> options) : base(options) { }

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
            modelBuilder.Entity<CompositeDataModel>().HasKey(a => a.Name);

            modelBuilder.Entity<MaterialDataModel>().HasKey(a => a.Name);

            // Set up limits
            //modelBuilder.Entity<MaterialDataModel>().Property(a => a.Name).HasMaxLength(50);
        }

        #endregion
    }
}
