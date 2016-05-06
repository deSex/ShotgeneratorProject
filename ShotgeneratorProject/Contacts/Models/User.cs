using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contracts.Models.UserSettings;

namespace Contracts.Models.User
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }        
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public UserSettings.UserSettings UserSettings { get; set; }

    }
}