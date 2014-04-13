using ECA.Model;
using ECA.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECA.Web.Controllers
{
    public class HomeController : BaseController
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult  ProductGrid()
        {
            CatalogService.CatalogServiceClient client= new CatalogService.CatalogServiceClient();
            List<BookCategory> booksByCategory =  client.GetAllBooksGroupedByCategory();
            List<CategoryViewModel> categoryViewModelList = booksByCategory.Select(bc => new CategoryViewModelBuilder(bc).Build()).ToList();
            return View("_ProductGrid",categoryViewModelList);

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
