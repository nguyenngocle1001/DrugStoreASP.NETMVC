using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugStore.Controllers.User
{
    public class PartialController : Controller
    {
        // GET: Partial
        public ActionResult LeftSideBar()
        {
            return PartialView();
        }

        public ActionResult Categorys()
        {
            return PartialView();
        }

        public ActionResult Manufactures()
        {
            return PartialView();
        }
    }
}