using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrugStore.Models;

namespace DrugStore.Controllers.Admin
{
    public class UsersController : Controller
    {
        DrugsDBDataContext _data = new DrugsDBDataContext();
        // GET: Users
        public ActionResult Users()
        {
            var user = _data.Users.ToList();
            return View(user);
        }
        public ActionResult AddUsers()
        {
            return View(_data.Roles.ToList());
        }

        [HttpPost]
        public ActionResult AddUsers(FormCollection form, HttpPostedFileBase avatar)
        {

            ViewData["errorUsername"] = "";
            ViewData["errorPassword"] = "";
            ViewData["errorFullname"] = "";
            ViewData["errorEmail"] = "";
            ViewData["errorPhone"] = "";
            ViewData["errorAddress"] = "";
            ViewData["errorAvatar"] = "";
            ViewData["notice"] = "";

            string username = form["username"];
            string password = form["password"];
            string fullname = form["fullname"];
            string email = form["email"];
            string phone = form["phone"];
            string address = form["address"];
            string role = form["role"];

            bool valid = true;

            if (String.IsNullOrEmpty(username))
            {
                ViewData["errorUsername"] = "<span class='error'>Bạn chưa nhập tên đăng nhập</span>";
                valid = false;
            }
            if (String.IsNullOrEmpty(password))
            {
                ViewData["errorPassword"] = "<span class='error'>Bạn chưa nhập mật khẩu</span>";
                valid = false;
            }
            if (String.IsNullOrEmpty(fullname))
            {
                ViewData["errorFullname"] = "<span class='error'>Bạn chưa nhập họ tên</span>";
                valid = false;
            }
            if (String.IsNullOrEmpty(email))
            {
                ViewData["errorEmail"] = "<span class='error'>Bạn chưa nhập email</span>";
                valid = false;
            }
            if (String.IsNullOrEmpty(phone))
            {
                ViewData["errorPhone"] = "<span class='error'>Bạn chưa nhập số điện thoại</span>";
                valid = false;
            }
            if (String.IsNullOrEmpty(address))
            {
                ViewData["errorAddress"] = "<span class='error'>Bạn chưa nhập địa chỉ</span>";
                valid = false;
            }
            if (avatar == null)
            {
                ViewData["errorAvatar"] = "<span class='error'>Bạn Chọn hình</span>";
                valid = false;
            }

            if (valid)
            {
                var count = _data.Users.Where(u => u.User_Namme == username).Count();
                if (count > 0)
                {
                    ViewData["notice"] = "<span class='error'>" + username + " đã tồn tại</span>";
                }
                else
                {
                    String fileName = Path.GetFileName(avatar.FileName);
                    string path = Path.Combine(Server.MapPath("~/images/Avts"), fileName);
                    Models.User user = new Models.User();
                    user.User_Namme = username;
                    user.Password = Encrypt.MD5Hash(password);
                    user.Full_Name = fullname;
                    user.Email = email;
                    user.Phone = phone;
                    user.Address = address;
                    user.Role_Id = int.Parse(role);
                    user.Avatar = fileName;
                    _data.Users.InsertOnSubmit(user);
                    _data.SubmitChanges();

                    avatar.SaveAs(path);

                    ViewData["notice"] = "<span class='success'>" + username + " đã thêm thành công</span>";
                }
            }

            return View(_data.Roles.ToList());
        }
    }
}