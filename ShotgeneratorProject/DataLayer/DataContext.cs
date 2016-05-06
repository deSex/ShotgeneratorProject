using Contracts.Models.UserSettings;
using Contracts.Models.User;
using DataLayer.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ShotContext")
        {
            Database.SetInitializer<DbContext>(new
 DropCreateDatabaseAlways<DbContext>());
           // Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>("ShotContext"));
        }
        public DbSet<UserSettings> UserSettings { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Players> Attender { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         

            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<UserSettings>()
                .HasOptional(x => x.User)
                .WithRequired(ad => ad.UserSettings);
                
              
            base.OnModelCreating(modelBuilder);
        }
    }
}
