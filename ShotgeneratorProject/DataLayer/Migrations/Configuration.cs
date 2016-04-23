namespace DataLayer.Migrations
{
    using Contracts.Models.User;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataLayer.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataLayer.DataContext context)
        {
            IList<User> Users = new List<User>();

            Users.Add(new User("Alexander", "Helsinghof"));
            Users.Add(new User("Ludvig", "Flemmich"));

            foreach (var user in Users)
            {
                context.User.Add(user);
            }
            base.Seed(context);
        }
    }
}
