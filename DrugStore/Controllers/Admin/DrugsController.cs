using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrugStore.Models;

namespace DrugStore.Controllers.Admin
{
    public class DrugsController : Controller
    {
        // GET: Drugs
        DrugsDBDataContext drugsDB = new DrugsDBDataContext();
        public ActionResult Drugs()
        {

            return View(drugsDB.Drugs.ToList());
        }
        public ActionResult AddDrugs()
        {
            ViewBag.Manu_Id = new SelectList(drugsDB.Manufacturers.ToList().OrderBy(n => n.Name), "Manu_Id", "Name");
            ViewBag.Cate_Id = new SelectList(drugsDB.Categories.ToList().OrderBy(n => n.Cate_Name), "Cate_Id", "Cate_Name");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddDrugs(Drug drug, FormCollection collection, HttpPostedFileBase fileUpload)
        {
            ViewBag.Manu_Id = new SelectList(drugsDB.Manufacturers.ToList().OrderBy(n => n.Name), "Manu_Id", "Name");
            ViewBag.Cate_Id = new SelectList(drugsDB.Categories.ToList().OrderBy(n => n.Cate_Name), "Cate_Id", "Cate_Name");

            return RedirectToAction("Drugs");
        }
    }
}