using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.QualityTools.Testing.Fakes;
using ECA.Model.Fakes;
using System.Linq;
using System.Data.Entity;
using ECA.BusinessLayer.SQL;
using System.Collections.Generic;
using ECA.Model;
using System.Data.Entity.Fakes;

namespace ECA.Tests.BookRepositoryTests
{
    [TestClass]
    public class SQLCartRepositoryTests : BaseRepositoryTests<SQLCartRepository>
    {
        public SQLCartRepositoryTests()
        {
            ShimDbSet<Cart>.AllInstances.AddT0
               = (dbset, cartItem) => { TestInit.MockDb.Carts.Add(cartItem); return cartItem; };
        }
        [TestMethod]
        public void GetCartItems_Test()
        {
            var cart = _repository.GetCartItems(1);
            Assert.IsTrue(cart.Count().Equals(2));
            Assert.IsTrue(cart.OrderBy(c => c.UserId).FirstOrDefault().UserId == 1 && cart.OrderBy(c => c.UserId).FirstOrDefault().ItemCode == "BOOK1");
        }
        [TestMethod]
        public void SaveCartItems_Test()
        {
            List<Model.Cart> cartItems = new List<Model.Cart>();
            cartItems.Add(new Model.Cart() { ItemCode = "BOOK1", UserId = 4,Quantity = 1 });
            cartItems.Add(new Model.Cart() { ItemCode = "BOOK2", UserId = 4,Quantity = 2 });

            _repository.SaveCartItems(cartItems);

            var cart = _repository.GetCartItems(4);

            Assert.IsTrue(cart.Any(c => c.ItemCode == "BOOK1" && c.UserId == 4 && c.Quantity == 1));
            Assert.IsTrue(cart.Any(c => c.ItemCode == "BOOK2" && c.UserId == 4 && c.Quantity == 2));
        }

        protected override SQLCartRepository GetRepository()
        {
            return new SQLCartRepository(new ECAEntities());
        }
        protected override string GetRepositoryCacheKey()
        {
            return "CartRepository";
        }

    }
}
