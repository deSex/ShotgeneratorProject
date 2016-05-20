using Contacts.Models.Viewmodels;
using Contracts.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShotGeneratorProject.Api.Helper
{
    public static class GeneratorHelper
    {
        public static User doStuff(UserViewModel updatedUser)
        {
            User user = new User
            {
                Username = updatedUser.Email,
                Password = updatedUser.Password,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                //UserSettings = updatedUser.UserSettings,
            };
          // user.UserSettings.Players = updatedUser.UserSettings.Players;
          
            return user;
        }
    }
}