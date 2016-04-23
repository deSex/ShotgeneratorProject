using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contracts.Models.User
{
    public class User
    {
        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string CreatedDate { get; set; }
        public int ShotsTaken { get; set; }

    }
}