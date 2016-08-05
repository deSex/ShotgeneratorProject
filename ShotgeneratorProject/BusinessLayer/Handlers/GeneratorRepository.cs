using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Models.User;
using DataLayer;
using Contracts.Models.UserSettings;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Contacts.Models.Viewmodels;

namespace BusinessLayer.Handlers
{
    public class GeneratorRepository : IUnitOfWork, IDisposable
    {
        private DataContext _ctx;
        private UserManager<IdentityUser> _userManager;

        public GeneratorRepository()
        {
            this._ctx = new DataContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(UserViewModel userModel)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = userModel.Email,
                Email = userModel.Email
            };
            var result = await _userManager.CreateAsync(user, userModel.Password);
            return result;
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = await _userManager.FindAsync(userName, password);

            return user;
        }

        public User GetUserById(int id)
        {
            return _ctx.User.Find(id);
        }


        public void InsertUser(int userId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _ctx.Dispose();
                    _userManager.Dispose();
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
        
            _ctx.UserSettings.Add(userSettings);
            _ctx.SaveChanges();

        }

        public void SaveUser(User user)
        {
            _ctx.User.Add(user);
            _ctx.SaveChanges();
        }
    }
}
