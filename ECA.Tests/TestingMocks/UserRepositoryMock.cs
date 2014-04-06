using ECA.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ECA.Tests.TestingMocks
{
    public class UserRepositoryMock : IUserRepository
    {
        public UserRepositoryMock()
        {
        }
        public IQueryable<Model.User> GetUsers()
        {
            return TestInit.MockDb.Users.AsQueryable();
        }


        public IQueryable<Model.User> GetUsersWithRole()
        {
            return TestInit.MockDb.Users.AsQueryable();
        }


        public IQueryable<Model.webpages_Membership> GetMemberships()
        {
            return TestInit.MockDb.webpages_Membership.AsQueryable();
        }


        public string CreateMembership(Model.webpages_Membership membership)
        {
             return TestInit.MockDb.webpages_Membership.Add(membership).UserId.ToString();
        }

        public string CreateUser(Model.User user)
        {
            return TestInit.MockDb.Users.Add(user).UserId.ToString();
        }
    }
}
