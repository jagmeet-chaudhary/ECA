using ECA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECA.BusinessLayer.Interfaces
{
    public interface IUserRepository
    {
        IQueryable<User> GetUsers();
        IQueryable<User> GetUsersWithRole();
        IQueryable<webpages_Membership> GetMemberships();
        string CreateMembership(webpages_Membership membership);
        string CreateUser(User user);
    }
}
 