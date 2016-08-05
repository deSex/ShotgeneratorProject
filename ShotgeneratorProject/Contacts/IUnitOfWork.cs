using Contracts.Models.UserSettings;
using Contracts.Models.User;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        User GetUserById(int userId);
        void InsertUser(int userId);
        void UpdateUser(User user);
        void AddGeneratorSettings(UserSettings userSettings);
        void SaveUser(User user);
    

    }
}
