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
    

    }
}
