using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrugStore.Models;

namespace DrugStore.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        DrugsDBDataContext drugsDB = new DrugsDBDataContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            Session["user"] = "";
            var user = collection["username"];
            var pass = collection["password"];
            ViewData["Error1"] = "";
            ViewData["Error2"] = "";            
            Boolean valid = true;
            if (String.IsNullOrEmpty(user))
            {
                valid = false;
                ViewData["Error1"] = "Chưa nhập tên đăng nhập";
            }
            if (String.IsNullOrEmpty(pass))
            {
                valid = false;
                ViewData["Error2"] = "Chưa nhập mật khẩu";
            }
            if (valid)
            {
                Models.User ad = drugsDB.Users.SingleOrDefault(n => n.User_Namme == user && n.Password.Equals(pass));
                if (ad != null)
                {
                    Session["user"] = ad.Full_Name;
                    return RedirectToAction("Index", "Admin");
                }
                else
                    ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            return View();

        }
            public ActionResult Profile()
        {
            return View();
        }
       

    }
}