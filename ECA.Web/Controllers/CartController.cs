using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECA.Web.Controllers
{
    public class CartController : BaseController 
    {
        //
        // GET: /Cart/

        public ActionResult AddToCart()
        {
            return View();
        }

    }
}
