using DrugStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugStore.Controllers.Admin
{
    public class CategorysController : Controller
    {
        // GET: Categorys
        DrugsDBDataContext drugsDB = new DrugsDBDataContext();
        public ActionResult Categorys()
        {
            return View(drugsDB.Categories.ToList());

        }
        public ActionResult AddCategorys()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddCategorys(Category cate, FormCollection collection)
        {


            var CateName = collection["Cate_Name"];
            var Count = drugsDB.Categories.Where(c => c.Cate_Name == CateName).Count();
            Boolean valid = true;
            ViewData["errorName"] = "";
            if (String.IsNullOrEmpty(CateName))
            {
                valid = false;
                ViewData["errorName"] = "Chưa nhập tên";
            }
            if (Count > 0)
            {
                valid = false;
                ViewData["errorName"] = "Tên đã sử dụng";
            }
            if (valid)
            {
                cate.Cate_Name = CateName;
                drugsDB.Categories.InsertOnSubmit(cate);
                drugsDB.SubmitChanges();
                return RedirectToAction("Categorys");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            Category cate = drugsDB.Categories.SingleOrDefault(n => n.Cate_Id == id);
            ViewBag.CateID = cate.Cate_Id;
            if (cate == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(cate);

        }
        [HttpPost, ActionName("Delete")]
        public ActionResult AccessDelete(int id)
        {
            Category cate = drugsDB.Categories.SingleOrDefault(n => n.Cate_Id == id);
            ViewBag.CateID = cate.Cate_Id;
            if (cate == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            Boolean valid = true;
            ViewData["Error"] = "";
            var Count = drugsDB.Drugs.Where(d => d.Category == id).Count();
            if (Count > 0)
            {
                valid = true;
                ViewData["Error"] = "Loại thuốc này đang có sản phẩm không thể xóa";
                cate = drugsDB.Categories.SingleOrDefault(n => n.Cate_Id == id);
                ViewBag.CateID = cate.Cate_Id;
                return View(cate);
            }
            else
            {
                drugsDB.Categories.DeleteOnSubmit(cate);
                drugsDB.SubmitChanges();
                return RedirectToAction("Categorys");
            }

        }
        [HttpGet]
        public ActionResult EditCategorys(int id)
        {

            Category cate = drugsDB.Categories.SingleOrDefault(n => n.Cate_Id == id);
            if (cate == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(cate);

        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult EditCategorys(Category cate, FormCollection collections)
        {
            var CateName = collections["Cate_Name"];
            int id = int.Parse(collections["Cate_Id"]);
            var Count = drugsDB.Categories.Where(c => c.Cate_Name == CateName).Count();
            Boolean valid = true;
            ViewData["errorName"] = "";
            if (String.IsNullOrEmpty(CateName))
            {
                valid = false;
                ViewData["errorName"] = "Chưa nhập tên";
            }
            if (Count > 1)
            {
                valid = false;
                ViewData["errorName"] = "Tên đã sử dụng";
            }
            if (valid)
            {
                var dataEdit = drugsDB.Categories.Where(s => s.Cate_Id == id).FirstOrDefault();
                dataEdit.Cate_Name = CateName;
                drugsDB.SubmitChanges();
                return RedirectToAction("Categorys");
            }
            return View();
        }
    }
}