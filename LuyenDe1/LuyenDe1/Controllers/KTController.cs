using LuyenDe1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuyenDe1.Controllers
{
    public class KTController : Controller
    {
        OnlineShopDataContext db = new OnlineShopDataContext();
        // GET: KT
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult DropDown()
        {
            var res = db.Categories.ToList();
            return PartialView(res);
        }

        public PartialViewResult ListProduct()
        {
            var res = db.Products.Where(p => p.Available == true).ToList();
            return PartialView(res);
        }


        public ActionResult getProductByCategory(string name)
        {
            var res = from pr in db.Products
                       join ca in db.Categories
                       on pr.CategoryId equals ca.Id
                       where ca.Name == name
                       select new
                       {
                           Id = pr.Id,
                           Name = pr.Name,
                           UnitPrice = pr.UnitPrice,
                           Image = pr.Image,
                           Available = pr.Available,
                           CategoryId = pr.CategoryId,
                           Description = pr.Description,
                       };
            return Json(res, JsonRequestBehavior.AllowGet);
        }

    }
}