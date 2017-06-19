using MobileShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOAN_WEB2.Models.BUS;
    

namespace DOAN_WEB2.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]

    public class AdminSPController : Controller
    {

        // GET: Admin/AdminSP
        public ActionResult Index()
        {
            if (TempData["Success"] != null)
            {
                ViewBag.Success = TempData["Success"].ToString();
            }
            if (TempData["Error"] != null)
            {
                ViewBag.Error = TempData["Error"].ToString();
            }



            return View(MobileShopBus.DanhSachSP());
        }

        // GET: Admin/AdminSP/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/AdminSP/Create
        // GET: Admin/AdminSP/Create
        public ActionResult Create()
        {
            ViewBag.MaNhaSX = new SelectList(NhaSanXuatBus.DanhSach(), "MaNhaSX", "TenNhaSX");
            ViewBag.MaLoaiSP = new SelectList(PhanLoaiBus.DanhSach(), "MaLoaiSP", "TenLoaiSP");
            return View();
        }

        // POST: Admin/AdminSP/Create
        [HttpPost ValidateInput(false)]
        public ActionResult Create(SanPham sp)
        {


            //try
            //{
            if (HttpContext.Request.Files.Count > 0)
            {
                var hpf = HttpContext.Request.Files[0];
                if (hpf.ContentLength > 0)
                {
                    string fileName = Guid.NewGuid().ToString();
                    string fullPathWithFileName = "/css/images/" + fileName + ".jpg";
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                    sp.Hinh1 = fileName + ".jpg";
                }
            }
          
            MobileShopBus.ThemSP(sp);
            return RedirectToAction("Index");
        }
            //catch
            //{
            //    return View();
    

        // GET: Admin/AdminSP/Edit/5
        public ActionResult Edit(string id)
        {
            ViewBag.MaNhaSX = new SelectList(NhaSanXuatBus.DanhSach(), "MaNhaSX", "TenNhaSX");
            ViewBag.MaLoaiSanPham = new SelectList(PhanLoaiBus.DanhSach(), "MaLoaiSP", "TenLoaiSP");
            return View(MobileShopBus.ChiTiet(id));
        }

        // POST: Admin/AdminSP/Edit/5
        [HttpPost ValidateInput(false)]
        public ActionResult Edit(string id, SanPham sp)
        {

            {
                if (HttpContext.Request.Files.Count > 0)
                {
                    var hpf = HttpContext.Request.Files[0];
                    if (hpf.ContentLength > 0)
                    {
                        string fileName = Guid.NewGuid().ToString();

                        string fullPathWithFileName = "/css/images/" + fileName + ".jpg";
                        hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                        sp.HinhChinh = fullPathWithFileName;
                    }
                }
                MobileShopBus.SuaSanPham(id, sp);
                return RedirectToAction("Index");
            }

        }

        // GET: Admin/AdminSP/Delete/5

        public ActionResult Delete(string id)
        {
            MobileShopBus.XoaTamSanPham(id);
            return RedirectToAction("Index");
        }

        // POST: Admin/SanPham/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
    }
}
