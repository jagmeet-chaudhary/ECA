using ECA.BusinessLogic.Interfaces;
using ECA.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECA.Tests.TestingMocks
{
    public class CartRepositoryMock : ICartRepository
    {

        public CartRepositoryMock()
        {
        }
        public IQueryable<Model.Cart> GetCartItems(int UserId)
        {
            return TestInit.MockDb.Carts.AsQueryable();
        }

        public void SaveCartItems(List<Model.Cart> items)
        {
           
        }
    }
}
