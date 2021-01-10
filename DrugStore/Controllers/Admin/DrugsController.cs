using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrugStore.Models;


namespace DrugStore.Controllers.Admin
{

    public class DrugsController : Controller
    {
        // GET: Drugs
        DrugsDBDataContext drugsDB = new DrugsDBDataContext();

        public ActionResult Drugs()
        {

            return View(drugsDB.Drugs.ToList());
        }
        public ActionResult AddDrugs()
        {
            ViewBag.Manu_Id = new SelectList(drugsDB.Manufacturers.ToList().OrderBy(n => n.Name), "Manu_Id", "Name");
            ViewBag.Cate_Id = new SelectList(drugsDB.Categories.ToList().OrderBy(n => n.Cate_Name), "Cate_Id", "Cate_Name");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddDrugs(Drug drug, FormCollection collection, HttpPostedFileBase Images)
        {



            ViewBag.Manu_Id = new SelectList(drugsDB.Manufacturers.ToList().OrderBy(n => n.Name), "Manu_Id", "Name");
            ViewBag.Cate_Id = new SelectList(drugsDB.Categories.ToList().OrderBy(n => n.Cate_Name), "Cate_Id", "Cate_Name");
            var Manu = collection["Manu_Id"];
            var Cate = collection["Cate_Id"];
            var Drug_Name = collection["Drug_Name"];


            var Price = Decimal.Parse(collection["Price"]);
            
            var Quantity = collection["Quantity"];
            var Desc = collection["Desc"];
            var Mfg = String.Format("{0:MM/dd/yyyy}", collection["Mfg"]);
            var Exp = String.Format("{0:MM/dd/yyyy}", collection["Exp"]);
            if (Images == null)
            {
                ViewBag.ErrorImg = "Vui lòng chọn ảnh bìa";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var fileName = Path.GetFileName(Images.FileName);
                    //var path = Path.Combine(Server.MapPath("~/images/Products/"), fileName);
                    drug.Drug_Name = Drug_Name;
                    drug.Quantity = int.Parse(Quantity);
                    drug.Price = float.Parse(Price.ToString());
                    drug.Manufacturer = int.Parse(Manu);
                    drug.Category = int.Parse(Cate);
                    drug.Images = fileName;
                    drug.MFG = DateTime.Parse(Mfg);
                    drug.EXP = DateTime.Parse(Exp);
                    drug.Description = Desc;
                    drugsDB.Drugs.InsertOnSubmit(drug);
                    drugsDB.SubmitChanges();
                    String dir = "~/images/Products/" + drug.Drug_Id;
                    if (!Directory.Exists(Server.MapPath(dir)))
                    {
                        Directory.CreateDirectory(Server.MapPath(dir));
                    }
                    var path = Path.Combine(Server.MapPath(dir), fileName);

                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.ErrorImg = "Hình đã tồn tại";
                        return View();
                    }
                    else
                    {
                        Images.SaveAs(path);
                    }
                }


            }
            return RedirectToAction("Drugs");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Drug drug = drugsDB.Drugs.SingleOrDefault(n => n.Drug_Id == id);
            ViewBag.DrugID = drug.Drug_Id;
            if (drug == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(drug);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult AccessDelete(int id)
        {
            Drug drug = drugsDB.Drugs.SingleOrDefault(n => n.Drug_Id == id);
            ViewBag.DrugID = drug.Drug_Id;
            if (drug == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            drugsDB.Drugs.DeleteOnSubmit(drug);
            drugsDB.SubmitChanges();
            return RedirectToAction("Drugs");
        }


        [HttpGet]
        public ActionResult EditDrug(int id)
        {

            Drug drug = drugsDB.Drugs.SingleOrDefault(n => n.Drug_Id == id);
            if (drug == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ViewBag.Manu_Id = new SelectList(drugsDB.Manufacturers.ToList().OrderBy(n => n.Name), "Manu_Id", "Name", drug.Manufacturer);
            ViewBag.Cate_Id = new SelectList(drugsDB.Categories.ToList().OrderBy(n => n.Cate_Name), "Cate_Id", "Cate_Name", drug.Category);
            return View(drug);

        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult EditDrug(Drug drug, FormCollection collection, HttpPostedFileBase Images)
        {
            ViewBag.Manu_Id = new SelectList(drugsDB.Manufacturers.ToList().OrderBy(n => n.Name), "Manu_Id", "Name", drug.Manufacturer);
            ViewBag.Cate_Id = new SelectList(drugsDB.Categories.ToList().OrderBy(n => n.Cate_Name), "Cate_Id", "Cate_Name", drug.Category);
            int id = int.Parse(collection["Drug_Id"]);
            var Manu = collection["Manu_Id"];
            var Cate = collection["Cate_Id"];
            var Drug_Name = collection["Drug_Name"];
            var Price = Decimal.Parse(collection["Price"]);
            var Quantity = collection["Quantity"];
            var Desc = collection["Desc"];
            var Mfg = String.Format("{0:MM/dd/yyyy}", collection["Mfg"]);
            var Exp = String.Format("{0:MM/dd/yyyy}", collection["Exp"]);
            if (Images == null)
            {
                ViewBag.Thongbao = "Vui lòng chọn ảnh bìa";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var fileName = Path.GetFileName(Images.FileName);

                    var dataEdit = drugsDB.Drugs.Where(s => s.Drug_Id == id).FirstOrDefault();
                    dataEdit.Drug_Name = Drug_Name;
                    dataEdit.Quantity = int.Parse(Quantity);
                    dataEdit.Price = float.Parse(Price.ToString());
                    dataEdit.Manufacturer = int.Parse(Manu);
                    dataEdit.Category = int.Parse(Cate);
                    dataEdit.Images = fileName;
                    dataEdit.MFG = DateTime.Parse(Mfg);
                    dataEdit.EXP = DateTime.Parse(Exp);
                    dataEdit.Description = Desc;
                    drugsDB.SubmitChanges();

                    var path = Path.Combine(Server.MapPath("~/images/Products/" + id + "/"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.Thongbao = "Hình đã tồn tại";
                    }
                    else
                    {
                        Images.SaveAs(path);
                    }
                }


            }
            return RedirectToAction("Drugs");
        }
    }
}