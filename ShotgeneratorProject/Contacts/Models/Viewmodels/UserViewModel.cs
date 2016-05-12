using Contracts.Models.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Models.Viewmodels
{
    public class UserViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public UserSettings UserSettings { get; set; }
       
    }
}
