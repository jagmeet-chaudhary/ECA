using ECA.Model;
using ECA.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECA.Web.Controllers
{
    public class BaseController : Controller
    {
        protected CartHeaderViewModel cartHeader;
        private HttpSessionStateBase _session;
        public HttpSessionStateBase CrossControllerSession 
        {
            get
            {
                if(_session == null) _session = Session;
                return _session ;
            }
            set
            {
                _session = Session;
            }
        }
        public BaseController()
        {
            
           // Cart cart = null;
           //if (Session["Cart"] == null)
           // {
 
           //     cart = new Cart() { Quantity = 0, UserId = 0 };
           //     Session["Cart"] = cart;
           // }
           // cart = Session["Cart"] as Cart;
           // cartHeader = new CartHeaderViewModel() { Quantity = Convert.ToInt32(cart.Quantity) };
        }
        

    }
}
