using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrugStore.Models;

namespace DrugStore.Controllers.Admin
{
    public class ManufacturesController : Controller
    {
        DrugsDBDataContext _data = new DrugsDBDataContext();
        // GET: Manufactures
        public ActionResult Manufactures()
        {
            return View(_data.Manufacturers.ToList());
        }
        public ActionResult AddManufactures()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddManufactures(FormCollection form)
        {
            ViewData["errorName"] = "";
            ViewData["notice"] = "";
            string name = form["name"];
            if (string.IsNullOrEmpty(name))
            {
                ViewData["errorName"] = "<span class='error'>Bạn chưa nhập tên nhà sản xuất</span>";
            }
            else
            {
                var count = _data.Manufacturers.Where(m => m.Name == name).Count();
                if (count > 0)
                {
                    ViewData["notice"] = "<span class='error'>Nhà sản xuất: " + name + " đã tồn tại</span>";
                }
                else
                {
                    Manufacturer manufacturer = new Manufacturer();
                    manufacturer.Name = name;
                    _data.Manufacturers.InsertOnSubmit(manufacturer);
                    _data.SubmitChanges();
                    ViewData["notice"] = "<span class='success'>Đã thêm nhà sản xuất: " + name + "</span>";
                }
            }
            return View();
        }

        public ActionResult EditManufactures(int id)
        {
            Manufacturer manufacturer = _data.Manufacturers.Where(m=>m.Id == id).First();
            return View(manufacturer);
        }

        [HttpPost]
        public ActionResult EditManufactures(FormCollection form, int id)
        {
            ViewData["errorName"] = "";
            ViewData["notice"] = "";
            Manufacturer manufacturer = _data.Manufacturers.Where(m => m.Id == id).First();
            string name = form["name"];
            if (string.IsNullOrEmpty(name))
            {
                ViewData["errorName"] = "<span class='error'>Bạn chưa nhập tên nhà sản xuất</span>";
            }
            else
            {
                var count = _data.Manufacturers.Where(m => m.Name == name && m.Id != id).Count();
                if (count > 0)
                {
                    ViewData["notice"] = "<span class='error'>Nhà sản xuất: " + name + " đã tồn tại</span>";
                }
                else
                {
                    manufacturer.Name = name;
                    _data.SubmitChanges();
                    return RedirectToAction("Manufactures", "Manufactures");
                }
            }
            return View(manufacturer);
        }

        public ActionResult Detroys(int id)
        {
            String message;
            var count = _data.Drugs.Where(d=>d.Manufacturer == id).Count();
            if (count <= 0)
            {
                Manufacturer manufacturer = _data.Manufacturers.Where(m => m.Id == id).First();
                _data.Manufacturers.DeleteOnSubmit(manufacturer);
                _data.SubmitChanges();
                message = "Deleted";
            }
            else
            {
                message = "Can not Delete";
            }
            Session.Add("Detroys_Manufacturer", message);
            return RedirectToAction("Manufactures", "Manufactures");
        }
    }
}