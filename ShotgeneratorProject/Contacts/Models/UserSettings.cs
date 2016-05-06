using System.Collections.Generic;

namespace Contracts.Models.UserSettings
{
    public class UserSettings
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Interval { get; set; }
        public string Mode { get; set; }
        public int UserId { get; set; }
        public User.User User { get; set; }
        public ICollection<Players> Players { get; set; }

    }

    public class Players
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Shotstaken { get; set; }
    }
}