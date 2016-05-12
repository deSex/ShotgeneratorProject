using Contracts.Models.UserSettings;
using Contracts.Models.User;
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
        public DataContext() : base("name=ShotContext")
        {
           Database.SetInitializer<DbContext>(new DropCreateDatabaseAlways<DbContext>());
           // Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, DataLayer.Migrations.Configuration>("ShotContext"));
        }
        public DbSet<UserSettings> UserSettings { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Players> Attender { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Players>()
                .HasRequired<UserSettings>(s => s.UserSettings)
                .WithMany(y => y.Players);


            base.OnModelCreating(modelBuilder);
        }
    }
    public class ShotDbInitializer : CreateDatabaseIfNotExists<DbContext>
    {
        protected override void Seed(DbContext context)
        {
            base.Seed(context);
        }
    }
}
