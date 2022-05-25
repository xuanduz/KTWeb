using LuyenDe2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuyenDe2.Controllers
{
    public class KiemTraController : Controller
    {
        OnlineShopDataContext db = new OnlineShopDataContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Dropdown()
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
            if(name == "all")
            {
                var allProduct = from pr in db.Products
                                 join ca in db.Categories
                                 on pr.CategoryId equals ca.Id
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
                return Json(allProduct, JsonRequestBehavior.AllowGet);
            }
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

        [HttpPost]
        public ActionResult SignUp(Customer newCus)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    OnlineShopDataContext db = new OnlineShopDataContext();
                    Customer customer = new Customer();
                    customer.Id = newCus.Id;
                    customer.Fullname = newCus.Fullname;
                    customer.Email = newCus.Email;
                    customer.Password = newCus.Password;
                    customer.RePassword = newCus.RePassword;
                    db.SubmitChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Sai kiểu");
                }
            }
            return View("Index");
        }
    }
}