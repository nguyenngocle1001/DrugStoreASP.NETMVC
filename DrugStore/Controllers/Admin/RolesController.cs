using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrugStore.Models;

namespace DrugStore.Controllers.Admin
{
    public class RolesController : Controller
    {
        DrugsDBDataContext _data = new DrugsDBDataContext();
        // GET: Roles
        public ActionResult Roles()
        {
            var roles = _data.Roles.ToList();
            return View(roles);
        }
        public ActionResult AddRoles()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRoles(FormCollection form)
        {
            String name = form["name"];
            String description = form["description"];
            ViewData["errorName"] = "";
            ViewData["errorDescription"] = "";
            ViewData["notice"] = "";
            bool valid = true;
            if (String.IsNullOrEmpty(name))
            {
                valid = false;
                ViewData["errorName"] = "Bạn chưa nhập tên quyền";
            }
            if (String.IsNullOrEmpty(description))
            {
                valid = false;
                ViewData["errorDescription"] = "Bạn chưa nhập mô tả quyền";
            }
            if (valid)
            {
                var count = _data.Roles.Where(role => role.Role_Name == name).Count();
                if (count <= 0)
                {
                    Role role = new Role();
                    role.Role_Name = name;
                    role.Description = description;
                    _data.Roles.InsertOnSubmit(role);
                    _data.SubmitChanges();
                    ViewData["notice"] = "Đã thêm";
                }
                else
                {
                    ViewData["notice"] = "Đã có quyền này rồi";
                }
            }

            return View();
        }

        public ActionResult EditRoles(int id)
        {
            var role = _data.Roles.Where(d => d.Role_Id == id).First();
            return View(role);
        }

        [HttpPost]
        public ActionResult EditRoles(FormCollection form, int id)
        {
            String name = form["name"];
            String description = form["description"];
            ViewData["errorName"] = "";
            ViewData["errorDescription"] = "";
            ViewData["notice"] = "";
            bool valid = true;
            if (String.IsNullOrEmpty(name))
            {
                valid = false;
                ViewData["errorName"] = "Bạn chưa nhập tên quyền";
            }
            if (String.IsNullOrEmpty(description))
            {
                valid = false;
                ViewData["errorDescription"] = "Bạn chưa nhập mô tả quyền";
            }

            Role role = _data.Roles.Where(r => r.Role_Id == id).First();

            if (valid)
            {
                var count = _data.Roles.Where(r => r.Role_Name == name && r.Role_Id != id).Count();
                if (count <= 0)
                {

                    role.Role_Name = name;
                    role.Description = description;

                    _data.SubmitChanges();
                    return RedirectToAction("Roles", "Roles");
                }
                else
                {
                    ViewData["notice"] = "Đã có quyền này rồi";
                }
            }
            return View(role);
        }

        public ActionResult Detroys(int id)
        {
            String message;
            var count = _data.Users.Where(u => u.Role_Id == id).Count();
            if (count <= 0)
            {
                Role role = _data.Roles.Where(r => r.Role_Id == id).First();
                _data.Roles.DeleteOnSubmit(role);
                _data.SubmitChanges();
                message = "Deleted";
            }
            else
            {
                message = "Can not Delete";
            }
            Session.Add("Detroys_Role", message);
            return RedirectToAction("Roles", "Roles");
        }
    }
}