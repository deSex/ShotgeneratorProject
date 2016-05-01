using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contracts.Models.TemporaryUser
{
    public class TemporaryUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Interval { get; set; }
        public int Mode { get; set; }
        public List<Players> Players { get; set; }
    }
    public class Players
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }

}