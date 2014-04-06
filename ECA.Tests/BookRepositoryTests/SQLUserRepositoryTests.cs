using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECA.BusinessLayer.SQL;
using ECA.Model;
using System.Linq;
using System.Web;
using Microsoft.QualityTools.Testing.Fakes;
using System.Data.Entity.Fakes;
using ECA.Model.Fakes;

namespace ECA.Tests.BookRepositoryTests
{
    [TestClass]
    public class SQLUserRepositoryTests : BaseRepositoryTests<SQLUserRepository>
    {
        public SQLUserRepositoryTests()
        {
           
           ShimDbSet<webpages_Membership>.AllInstances.AddT0 
               = (dbset, mem_input) => { TestInit.MockDb.webpages_Membership.Add(mem_input); return mem_input; };
        }
        [TestMethod]
        public void GetUsers_return_correct_users()
        {
            IQueryable<User> userList = _repository.GetUsers();
            Assert.IsTrue(userList.Count().Equals(3));
        }
        [TestMethod]
        public void GetUsersWithRole_correct_roles()
        {
            IQueryable<User> userList = _repository.GetUsersWithRole();
            Assert.IsTrue(userList.Where(u => u.UserId == 2).FirstOrDefault().webpages_Roles.Where(r => r.RoleId == 3).Count().Equals(1));
        }
        [TestMethod]
        public void GetMemberships_correct_memberships()
        {
            IQueryable<webpages_Membership> memList = _repository.GetMemberships();
            Assert.IsTrue(memList.Any(mem => mem.UserId == 1 && mem.Password == "abcd"));
        }
        [TestMethod]
        public void CreateMembership_creates_correct_record()
        {
            webpages_Membership membership = new webpages_Membership();
            membership.UserId = 3;
            membership.Password = "3333";
            _repository.CreateMembership(membership);
            IQueryable<webpages_Membership> list =  _repository.GetMemberships();
            Assert.IsTrue(list.Where(mem=>mem.UserId == 3).FirstOrDefault().Password == "3333");
        }
        protected override SQLUserRepository GetRepository()
        {
            return new SQLUserRepository(new ECAEntities());
        }
       
        protected override string GetRepositoryCacheKey()
        {
            return "UserRepository";
        }
    }
}
