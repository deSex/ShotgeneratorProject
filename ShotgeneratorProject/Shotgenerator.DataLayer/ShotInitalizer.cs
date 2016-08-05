using ShotGeneratorProject.Api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shotgenerator.DataLayer
{
    public class ShotInitalizer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {

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