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

            return View(MobileShopBus.DanhSachSP());
        }

        // GET: Admin/AdminSP/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/AdminSP/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminSP/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(SanPham sp)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here
        //        MobileShopBus.ThemSP(sp);

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        {
            {
                // TODO: Add insert logic here
                //Hàm thêm
                if (HttpContext.Request.Files.Count > 0) { }

                var hpf = HttpContext.Request.Files[0];
                if (hpf.ContentLength > 0)
                {
                    string fileName = Guid.NewGuid().ToString();

                    string fullPathWithFileName = "/css/img/products/" + fileName + ".jpg";
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                    sp.HinhChinh = fullPathWithFileName;
                }
            }
            MobileShopBus.ThemSP(sp);
            return RedirectToAction("Index");
            //try
            //{
            //    // TODO: Add insert logic here
            //    SanPhamBus.ThemSP(sp);
            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: Admin/AdminSP/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/AdminSP/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/AdminSP/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/AdminSP/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
