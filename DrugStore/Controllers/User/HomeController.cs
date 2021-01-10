using DrugStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugStore.Controllers.User
{
    public class HomeController : Controller
    {
        DrugsDBDataContext drugsDB = new DrugsDBDataContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }

        public ActionResult NewProducts()
        {
            var prod = drugsDB.Drugs.OrderByDescending(a => a.Drug_Id).Take(3).ToList();
            return PartialView(prod);
        }
        public ActionResult BestSellerProducts()
        {
            var prod = drugsDB.Drugs.OrderByDescending(a => a.Quantity).Take(3).ToList();
            return PartialView(prod);
        }
        public ActionResult Details()
        {
            return View();
        }

        public ActionResult ProductsCategory()
        {
            return View();
        }

        public ActionResult ProductsManufacture()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }
    }
}