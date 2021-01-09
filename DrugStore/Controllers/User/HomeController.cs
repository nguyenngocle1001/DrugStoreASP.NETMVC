using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrugStore.Models;

namespace DrugStore.Controllers.User
{
    public class HomeController : Controller
    {
        DrugsDBDataContext _data = new DrugsDBDataContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            var products = _data.Drugs.OrderByDescending(d=>d.Drug_Id).ToList();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var product = _data.Drugs.Where(d => d.Drug_Id == id).First();
            return View(product);
        }

        public ActionResult ProductsCategory(int id)
        {
            var products = _data.Drugs.Where(d => d.Category == id).OrderByDescending(d => d.Drug_Id).ToList();
            var manu = _data.Categories.Where(m => m.Cate_Id == id).First();
            ViewData["Name"] = manu.Cate_Name;
            return View(products);
        }

        public ActionResult ProductsManufacture(int id)
        {
            var products = _data.Drugs.Where(d=>d.Manufacturer == id).OrderByDescending(d => d.Drug_Id).ToList();
            var manu = _data.Manufacturers.Where(m => m.Id == id).First();
            ViewData["Name"] = manu.Name;
            return View(products);
        }

        [HttpPost]
        public ActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(FormCollection form)
        {
            var search = form["Search"];
            var products = _data.Drugs.Where(d=>d.Drug_Name.Contains(search)).ToList();
            ViewData["Search"] = search;
            return View(products);
        }
    }
}