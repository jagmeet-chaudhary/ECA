using ECA.BusinessLayer.Interfaces;
using ECA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ECA.BusinessLayer.SQL
{
    public class SQLUserRepository : SQLBaseRepository, IUserRepository 
    {
        public SQLUserRepository() : base()
        {
        }
        public SQLUserRepository(ECAEntities _DB)
            : base(_DB)
       {
        }
        public IQueryable<Model.User> GetUsers()
        {
            return Db.Users.AsQueryable();
        }
        public IQueryable<Model.webpages_Membership> GetMemberships()
        {
            return Db.webpages_Membership.AsQueryable();
        }

        public IQueryable<User> GetUsersWithRole()
        {
            
            return Db.Users.Include(u=>u.webpages_Roles).AsQueryable();
        }


        public string CreateMembership(webpages_Membership membership)
        {
            Db.webpages_Membership.Add(membership);
            int val = Db.SaveChanges();
            return val.ToString();
        }

        public string CreateUser(User user)
        {
            Db.Users.Add(user);
            int val = Db.SaveChanges();
            return val.ToString();
        }
    }
}
