using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugStore.Controllers.Admin
{
    public class RolesController : Controller
    {
        // GET: Roles
        public ActionResult Roles()
        {
            return View();
        }
        public ActionResult AddRoles()
        {
            return View();
        }
    }
}