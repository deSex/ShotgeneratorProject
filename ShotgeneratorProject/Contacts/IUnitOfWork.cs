using Contracts.Models.User;
using System;
namespace Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<User> UserRepository { get; }
        void Save();
    }
}
