using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contracts.Models.UserSettings;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Contracts.Models.User
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public UserSettings.UserSettings UserSettings { get; set; }
    }
}