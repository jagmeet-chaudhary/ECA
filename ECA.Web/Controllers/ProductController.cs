using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ECA.Model;
using ECA.Web.ViewModel;

namespace ECA.Web.Controllers
{
    public class ProductController : BaseController
    {
        CatalogService.CatalogServiceClient serviceClient = new CatalogService.CatalogServiceClient();

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Product/Details/5

        public ActionResult Details(string id)
        {
            var book = serviceClient.GetBookDetails(id);
            var bookViewModel = (new ProductViewModelBuilder(book)).Build();
            bookViewModel.ShoppingCartHeaderViewModel = cartHeader;
            return View("Product", bookViewModel);
        }

        //
        // GET: /Product/Create
       
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Product/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Product/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Product/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Product/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Product/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
