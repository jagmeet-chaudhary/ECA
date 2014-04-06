using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECA.Tests.BookRepositoryTests;
using ECA.BusinessLayer.SQL;
using ECA.Model;
using ECA.BusinessLogic.Interfaces;
using Microsoft.Practices.Unity;
using ECA.Repository;
using ECA.BusinessLayer.Interfaces;
using ECA.Tests.TestingMocks;
using ECA.BusinessLogic;
using System.Linq;
using System.Web.Security;
using System.Web.Helpers;


namespace ECA.Tests.BusinessLogicTests
{
    [TestClass]
    public class UserRoleTests : BaseBusinessLogicTests
    {
        public static IUserRole UserRoleLogic;
        public UserRoleTests()
        {

        }
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {

            container.RegisterType<IUserRepository, UserRepositoryMock>();
            UserRoleLogic = container.Resolve<UserRole>();
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            container.Teardown(UserRoleLogic);
        }
        [TestMethod]
        public void ValidateUser_returns_false_user_not_in_db()
        {
           
            bool result = UserRoleLogic.ValidateUser("jag","abcd");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void ValidateUser_returns_false_password_wrong()
        {

            bool result = UserRoleLogic.ValidateUser("Jagmeet Singh", "abcd1");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void ValidateUser_returns_true_user_in_db_and_password_correct()
        {
            
            bool result = UserRoleLogic.ValidateUser("Jagmeet Singh","abcd");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GetUser_returns_correct_user()
        {
            User user = UserRoleLogic.GetUser(1);
            Assert.IsTrue(user.UserId == 1 && user.UserName == "Jagmeet Singh");
        }
        [TestMethod]
        public void GetUserRole_returns_correct_number_of_roles()
        {
            User user = UserRoleLogic.GetUserRoles(1);
            Assert.IsTrue(user.UserId == 1);
            Assert.IsTrue(user.webpages_Roles.FirstOrDefault().RoleId == 1);
            
        }
        [TestMethod]
        public void CreateUser_add_correct_user()
        {
            User user = new User();
            user.UserId = 22;
            user.FirstName = "Abcd";
            user.LastName = "xyz";
            user.UserName ="abcd_xyz";

            UserRoleLogic.CreateUser(user);
            user = UserRoleLogic.GetUser(22);
            Assert.IsTrue(user.FirstName == "Abcd" && user.LastName == "xyz" && user.UserName == "abcd_xyz" && user.UserId == 22);
        }
        [TestMethod]
        [ExpectedException(typeof(MembershipCreateUserException))]
        public void CreateUser_throws_MembershipCreateUserException_if_username_null()
        {
            User user = new User();
            user.UserId = 22;
            user.FirstName = "Abcd";
            user.LastName = "xyz";
            user.UserName = "";

            UserRoleLogic.CreateUser(user);
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void CreateAccount_throws_MembershipCreateUserException_if_password_null()
        {
            webpages_Membership membership = new webpages_Membership();
            membership.UserId = 22;
            UserRoleLogic.CreateAccount(membership);
        }
        [TestMethod]
        public void CreateAccount_throws_MembershipCreateUserException_if_password_GT_128()
        {

        }
        [TestMethod]
        public void CreateAccount_add_correct_membership()
        {
        }
        [TestMethod]
        public void CreateUserAndAccount_add_correct_user_and_membership()
        {
        }
       
    }
}
