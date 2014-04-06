using ECA.BusinessLayer.Interfaces;
using ECA.BusinessLogic.Interfaces;
using ECA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECA.BusinessLogic
{
    public class UserRole : IUserRole
    {
        private IUserRepository _repository;
        public UserRole(IUserRepository userRepository)
        {
            _repository = userRepository;
        }
        public bool ValidateUser(string UserName,string Password)
        {
            User user = _repository.GetUsers().Select(u => u).Where(u => u.UserName == UserName).FirstOrDefault();
            if (user == null)
                return false;

            return _repository.GetMemberships().Any(mem => mem.Password == Password);
        }

        public Model.User GetUser(int UserId)
        {
            return _repository.GetUsers().Where(u => u.UserId == UserId).FirstOrDefault();
        }

        public Model.User GetUserRoles(int UserId)
        {
            return _repository.GetUsersWithRole().Where(u => u.UserId == UserId).FirstOrDefault();
        }


        public string CreateUserAndAccout(User user, webpages_Membership membership)
        {
            //var retUser = _repository.CreateUser(user);
            
            //var retMem = _repository.CreateMembership(membership);
            //return retUser + "_" + retMem;
            throw new NotImplementedException();
        }

        public string CreateUser(User user)
        {
            //return _repository.CreateUser(user);
            throw new NotImplementedException();
        }

        public string CreateAccount(webpages_Membership membership)
        {
            //return _repository.CreateMembership(membership);
            throw new NotImplementedException();
        }
    }
}
