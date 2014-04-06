using ECA.BusinessLogic;
using ECA.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ECA.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CartService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CartService.svc or CartService.svc.cs at the Solution Explorer and start debugging.
    public class CartService : ICartService
    {
        ICart  _cart;
        public CartService(ICart cart)
        {
            _cart = cart;
        }
        public List<Model.Cart> GetCartItems(int userId)
        {
            return _cart.GetCartItems(userId).ToList();
        }
    }
}
