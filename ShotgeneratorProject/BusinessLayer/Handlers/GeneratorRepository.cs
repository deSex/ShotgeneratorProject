using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Models.User;
using DataLayer;
using Contracts.Models.UserSettings;

namespace BusinessLayer.Handlers
{
    public class GeneratorRepository : IUnitOfWork, IDisposable
    {
        private DataContext context;

        public GeneratorRepository(DataContext context)
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

        protected virtual void CleanUpGC()
        {
            GC.SuppressFinalize(this);
        }

        public void Dispose()
        {
            Dispose(true);
            CleanUpGC();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void AddGeneratorSettings(UserSettings userSettings)
        {
        
            context.UserSettings.Add(userSettings);
            context.SaveChanges();

        }

        public void SaveUser(User user)
        {
            context.User.Add(user);
            context.SaveChanges();
        }
    }
}
