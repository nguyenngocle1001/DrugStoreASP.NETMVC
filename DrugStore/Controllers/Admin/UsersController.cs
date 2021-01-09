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

            var username = form["username"];
            var password = form["password"];
            var fullname = form["fullname"];
            var email = form["email"];
            var phone = form["phone"];
            var address = form["address"];
            var role = form["role"];

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
                    string fileName = Path.GetFileName(avatar.FileName);


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

                    string dir = "~/images/Avts/" + user.User_Id;
                    if (!Directory.Exists(Server.MapPath(dir)))
                    {
                        Directory.CreateDirectory(Server.MapPath(dir));
                    }
                    var path = Path.Combine(Server.MapPath(dir), fileName);
                    avatar.SaveAs(path);

                    ViewData["notice"] = "<span class='success'>" + username + " đã thêm thành công</span>";
                }
            }

            return View(_data.Roles.ToList());
        }

        public ActionResult EditUsers(int id)
        {
            var user = _data.Users.Where(u => u.User_Id == id).First();
            ViewBag.Roles = new SelectList(_data.Roles.ToList().OrderBy(n => n.Role_Name), "Role_Id", "Role_Name", user.Role_Id);
            return View(user);
        }

        [HttpPost]
        public ActionResult EditUsers(FormCollection form, int id, HttpPostedFileBase avatar)
        {
            var user = _data.Users.Where(u => u.User_Id == id).First();
            ViewBag.Roles = new SelectList(_data.Roles.ToList().OrderBy(n => n.Role_Name), "Role_Id", "Role_Name", user.Role_Id);

            ViewData["errorFullname"] = "";
            ViewData["errorEmail"] = "";
            ViewData["errorPhone"] = "";
            ViewData["errorAddress"] = "";
            ViewData["notice"] = "";

            var fullname = form["fullname"];
            var email = form["email"];
            var phone = form["phone"];
            var address = form["address"];
            var role = form["Roles"];

            bool valid = true;

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

            if (valid)
            {

                user.Full_Name = fullname;
                user.Email = email;
                user.Phone = phone;
                user.Address = address;
                user.Role_Id = int.Parse(role);

                if(avatar != null)
                {
                    string fileName = Path.GetFileName(avatar.FileName);
                    string dir = "~/images/Avts/" + user.User_Id;
                    if (!Directory.Exists(Server.MapPath(dir)))
                    {
                        Directory.CreateDirectory(Server.MapPath(dir));
                    }
                    var path = Path.Combine(Server.MapPath(dir), fileName);
                    avatar.SaveAs(path);

                    user.Avatar = fileName;
                }
                
                _data.SubmitChanges();


                return RedirectToAction("Users", "Users");
            }

            return View(user);
        }

        public ActionResult Detroys(int id)
        {
            String message;
            var count = _data.Bills.Where(u => u.User_Id == id).Count();
            if (count <= 0)
            {
                Models.User user = _data.Users.Where(r => r.User_Id == id).First();
                _data.Users.DeleteOnSubmit(user);
                _data.SubmitChanges();
                message = "Deleted";
            }
            else
            {
                message = "Can not Delete";
            }
            Session.Add("Detroys_Role", message);
            return RedirectToAction("Users", "Users");
        }
    }
}