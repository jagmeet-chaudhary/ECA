using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECA.Repository.SQL.Fakes;
using Microsoft.QualityTools.Testing.Fakes;
using System.Collections.Generic;
using ECA.BusinessLayer.SQL.Fakes;
using System.Linq;
using ECA.Model;
using ECA.BusinessLogic.Interfaces;
using ECA.BusinessLogic;
using ECA.Repository;
using ECA.Tests.TestingMocks;
using Microsoft.Practices.Unity;

namespace ECA.Tests.BusinessLogicTests
{
    
    [TestClass]
    public class CartTests : BaseBusinessLogicTests 
    {
        public static ICart SCart { get; set; }
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            
            container.RegisterType<ICartRepository , CartRepositoryMock >();
            SCart = container.Resolve<ShoppingCart>();
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            container.Teardown(SCart);
        }
       
        [TestMethod]
        public void GetCartItems_return_correct_items()
        {
            List<Cart> cartItems = SCart.GetCartItems(1).ToList();
            Assert.IsTrue(cartItems.Count().Equals(2));

        }
        
    }
}
