using DrugStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugStore.Controllers.Admin
{
    public class BillsController : Controller
    {
        // GET: Bills
        DrugsDBDataContext drugsDB = new DrugsDBDataContext();
        public ActionResult Bills()
        {
            return View(drugsDB.Bills.ToList());
        }
        public ActionResult BillDetails(int id)
        {
            var b = (from s in drugsDB.Bills where s.Bill_Id == id select s.User_Id).ToList();
            int idUser = b.First();
            var c = (from s in drugsDB.Users where s.User_Id == idUser select s.Full_Name).ToList();

            var total = (from s in drugsDB.Bills where s.Bill_Id == id select s.Total).ToList();
            ViewBag.Total = total.First();
            ViewBag.Name = c.First();           
            return View(drugsDB.Bill_Details.ToList());
        }
    }
}