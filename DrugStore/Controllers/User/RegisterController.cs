using DrugStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugStore.Controllers.User
{
    public class RegisterController : Controller
    {
        // GET: Register
        DrugsDBDataContext drugsDB = new DrugsDBDataContext();

        [HttpPost]
        public ActionResult Register(FormCollection form)
        {
            string name = form["Name"];
            string username = form["UserName"];
            string tel = form["Tel"];
            string address = form["Address"];
            string email = form["Email"];
            string password1 = form["password"];
            string password2 = form["ConfirmPassword"];
            Boolean valid = true;
            var Count = drugsDB.Users.Where(c => c.User_Namme == username).Count();
            if (Count > 0)
            {
                valid = false;
                Session.Add("notice1", "<span class='error'>Tên đăng nhập đã tồn tại</span>");
            }
            if (password1 != password2)
            {
                valid = false;
                Session.Add("notice1", "<span class='error'>Nhập lại mật khẩu không khớp</span>");
            }
            if (valid)
            {
                Models.User user = new Models.User();
                user.User_Namme = username;
                user.Full_Name = name;
                user.Phone = tel;
                user.Address = address;
                user.Email = email;
                user.Avatar = "test.jpg";
                user.Password = Encrypt.MD5Hash(password1);
                user.Role_Id = 4;
                drugsDB.Users.InsertOnSubmit(user);
                drugsDB.SubmitChanges();
                Session.Remove("notice1");
                Session.Remove("notice2");
            }

            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}