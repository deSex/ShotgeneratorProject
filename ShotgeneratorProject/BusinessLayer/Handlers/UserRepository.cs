using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Models.User;
using DataLayer;
using Contracts.Models.TemporaryUser;

namespace BusinessLayer.Handlers
{
    public class UserRepository : IUnitOfWork, IDisposable
    {
        private DataContext context;

        public UserRepository(DataContext context)
        {
            this.context = context;
        }

        public User GetUserById(int id)
        {
            return context.User.Find(id);
        }


        public void InsertUser(int userId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            context.SaveChanges();
        }
       
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        protected virtual void DisposeAndCleanUpGC()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose()
        {
            DisposeAndCleanUpGC();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void AddTemporaryUser(TemporaryUser user)
        {
            context.TemporaryUser.Add(user);
            context.SaveChanges();
            
        }
    }
}
