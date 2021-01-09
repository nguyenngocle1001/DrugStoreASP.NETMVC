using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrugStore.Models;

namespace DrugStore.Controllers.User
{
    public class PartialController : Controller
    {
        DrugsDBDataContext _data = new DrugsDBDataContext();
        // GET: Partial
        public ActionResult LeftSideBar()
        {
            return PartialView();
        }

        public ActionResult Categorys()
        {
            var categorys = from cate in _data.Categories join dr in _data.Drugs on cate.Cate_Id equals dr.Category select cate;
            return PartialView(categorys);
        }

        public ActionResult Manufactures()
        {
            var manufactures = from manu in _data.Manufacturers join dr in _data.Drugs on manu.Id equals dr.Manufacturer select manu;
            return PartialView(manufactures);
        }
    }
}