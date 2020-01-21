using DataAccessLayer.Migrations;
using DataAccessLayer.Models;
using System.Data.Entity;
using System.Reflection;

namespace DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :
            base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>(true));
        }

        public DbSet<Argument> Arguments { get; set; }
        public DbSet<Collect> Collects { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<SolidWaste> SolidWastes{ get; set; }
        public DbSet<Subject> Subjects{ get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
