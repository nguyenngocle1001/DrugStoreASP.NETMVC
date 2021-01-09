using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugStore.Controllers.Admin
{
    public class CategorysController : Controller
    {
        // GET: Categorys
        public ActionResult Categorys()
        {
            return View();
        }
        public ActionResult AddCategorys()
        {
            return View();
        }
    }
}