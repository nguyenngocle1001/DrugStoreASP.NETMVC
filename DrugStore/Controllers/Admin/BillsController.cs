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
        public ActionResult Bills()
        {
            return View();
        }
        public ActionResult AddBills()
        {
            return View();
        }
    }
}