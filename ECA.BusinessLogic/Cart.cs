
using ECA.BusinessLayer.SQL;
using ECA.BusinessLogic.Interfaces;
using ECA.Model;
using ECA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECA.BusinessLogic
{
    public class ShoppingCart : ICart
    {
        private ICartRepository _repository;

        //public ShoppingCart()
        //{
        //    _repository = new SQLCartRepository();
        //}
        public ShoppingCart(ICartRepository repository)
        {
            _repository = repository;
        }



        public IList<Cart> GetCartItems(int userId)
        {
            return _repository.GetCartItems(userId).ToList();
        }
    }
}
