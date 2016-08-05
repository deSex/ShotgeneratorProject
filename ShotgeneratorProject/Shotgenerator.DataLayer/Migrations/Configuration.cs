namespace Shotgenerator.DataLayer.Migrations
{
    using ShotGeneratorProject.Api.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Shotgenerator.DataLayer.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Shotgenerator.DataLayer.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            IList<User> sampleUsers = new List<User>();

            sampleUsers.Add(new User("Alexander", "Helsinghof"));
            sampleUsers.Add(new User("Ludvig", "Flemmich"));
            sampleUsers.Add(new User("Ellinor", "Stenhaug"));
            sampleUsers.Add(new User("Josefine", "Ekenrud"));

            foreach (var user in sampleUsers)
            {
                context.User.Add(user);
            }

            base.Seed(context);

        }
    }
}
