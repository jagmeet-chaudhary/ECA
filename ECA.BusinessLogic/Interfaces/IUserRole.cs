using ECA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECA.BusinessLogic.Interfaces
{
    public interface IUserRole
    {
         bool ValidateUser(string UserName,string Password);
         User GetUser(int UserId);
         User GetUserRoles(int UserId);
         string CreateUserAndAccout(User user, webpages_Membership membership);
         string CreateUser(User user);
         string CreateAccount(webpages_Membership membership);
        

    }
}
