using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECA.Web.ViewModel
{
    public class BaseViewModel
    {
        public BaseViewModel()
        {
            ShoppingCartHeaderViewModel = new CartHeaderViewModel();
        }
        public CartHeaderViewModel ShoppingCartHeaderViewModel { get; set; }
    }

    public class CartHeaderViewModel
    {
        public Dictionary<string, Nullable<Decimal>> Items { get; set; }
        public int Quantity { get; set; }
        public Nullable<Decimal> Total { get; set; }
    }
   
}