using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contracts.Models.UserSettings
{
    public class UserSettings
    {
        [Key]
        public int Id { get; set; }      
        public string Interval { get; set; }    
        public ICollection<Players> Players { get; set; }
      
    }
    public class Players
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Shotstaken { get; set; }        
        public virtual UserSettings UserSettings { get; set; }

    }
}