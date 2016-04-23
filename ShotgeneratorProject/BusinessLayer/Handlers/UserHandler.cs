using Contracts;
using Contracts.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Handlers
{
    public class UserHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserHandler(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void UpdateUser(User user)
        {
           
        }
        public void DeleteUser(User user)
        {

        }
        public User GetUserById(int id)
        {
            return _unitOfWork.UserRepository.GetById(id);
        }
    }
}
