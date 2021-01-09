using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrugStore.Models;

namespace DrugStore.Controllers.User
{
    public class AccountController : Controller
    {
        // GET: Account
        DrugsDBDataContext _data = new DrugsDBDataContext();
        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            string username = form["username"];
            string password = Encrypt.MD5Hash(form["password"]);

            Models.User user = _data.Users.Where(u=>u.User_Namme == username && u.Password == password).FirstOrDefault();

            if (user != null)
            {
                Session.Add("USER_ID", user.User_Id);
                Session.Add("USER_NAME", user.User_Namme);
                Session.Remove("notice");
            }
            else
            {
                Session.Add("notice", "<span class='error'>Sai mật khẩu</span>");
            }

            return Redirect(Request.UrlReferrer.ToString());
        }

        public ActionResult Logout()
        {
            Session.Remove("USER_ID");
            Session.Remove("USER_NAME");
            return RedirectToAction("Index", "Home");
        }
    }
}