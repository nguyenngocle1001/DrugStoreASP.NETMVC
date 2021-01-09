using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugStore.Controllers.Admin
{
    public class ManufacturesController : Controller
    {
        // GET: Manufactures
        public ActionResult Manufactures()
        {
            return View();
        }
        public ActionResult AddManufactures()
        {
            return View();
        }
    }
}