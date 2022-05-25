using De1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace De1.Controllers
{
    public class ThuVienController : Controller
    {
        ThuVienDataContext db = new ThuVienDataContext();
        // GET: ThuVien
        public ActionResult Index()
        {
            var res = db.tSaches.Where(x => x.MaNgonNgu == "001").ToList();
            return View(res);
        }

        public PartialViewResult NgonNguPartial()
        {
            return PartialView(db.tNgonNgus.OrderBy(n => n.MaNgonNgu).ToList());
        }

        public JsonResult SachTheoNgonNgu(string NgonNgu)
        {
            var s = from p in db.tSaches
                    where p.tNgonNgu.TenNgonNgu == NgonNgu
                    select new
                    {
                        MaSach = p.MaSach,
                        TenSach = p.TenSach,
                        NgonNgu = p.tNgonNgu.TenNgonNgu,
                        TacGia = p.TacGia,
                        Anh = p.FileAnh,
                        GioiThieu = p.GioiThieu
                    };
            return Json(s, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            ThuVienDataContext db = new ThuVienDataContext();
            var res = db.tSaches.Where(s => s.MaSach == id).FirstOrDefault();
            return View(res);
        }

        [HttpPost]
        public ActionResult Edit(tSach ns)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ThuVienDataContext db = new ThuVienDataContext();
                    tSach oldBook = new tSach();
                    tSach sach = (from s in db.tSaches
                                  where s.MaSach == ns.MaSach
                                  select s).FirstOrDefault();
                    sach.MaSach = sach.MaSach;
                    sach.TenSach = ns.TenSach;
                    sach.MaLoai = ns.MaLoai;
                    sach.MaNgonNgu = ns.MaNgonNgu;
                    sach.MaNXB = ns.MaNXB;
                    sach.TacGia = ns.TacGia;
                    sach.NamXB = ns.NamXB;
                    sach.LanXB = ns.LanXB;
                    sach.TomTat = ns.TomTat;
                    sach.TongSoTrang = ns.TongSoTrang;
                    sach.Tap = ns.Tap;
                    sach.TongSoTap = ns.TongSoTap;
                    sach.GiaTriSach = ns.GiaTriSach;
                    sach.FileAnh = ns.FileAnh;
                    sach.MaTheLoai = ns.MaTheLoai;
                    sach.GioiThieu = ns.GioiThieu;
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