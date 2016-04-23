using Shotgenerator.DataLayer.Migrations;
using ShotGeneratorProject.Api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shotgenerator.DataLayer
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ShotContext")
        {
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>("ShotContext"));
        }
        public DbSet<TemporaryUser> TemporaryUser { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}