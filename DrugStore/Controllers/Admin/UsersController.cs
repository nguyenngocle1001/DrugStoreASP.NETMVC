using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugStore.Controllers.Admin
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Users()
        {
            return View();
        }
        public ActionResult AddUsers()
        {
            return View();
        }
    }
}