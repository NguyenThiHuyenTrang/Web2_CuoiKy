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

    public class AdminNSXController : Controller
    {
        public object NXS { get; private set; }

        // GET: Admin/AdminNSX
        public ActionResult Index()
        {
            var sql = NhaSanXuatBus.DanhSanhNSXAdmin();
            return View(sql);
        }

        // GET: Admin/AdminNSX/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/AdminNSX/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminNSX/Create
        [HttpPost]
        public ActionResult Create(NhaSanXuat NSX)
        {
            try
            {
                // TODO: Add insert logic here
                NhaSanXuatBus.ThemNSX(NSX);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/AdminNSX/Edit/5
        public ActionResult Edit(String id)
        {
            return View(NhaSanXuatBus.EditNSX(id));
        }

        // POST: Admin/AdminNSX/Edit/5
        [HttpPost]
        public ActionResult Edit(String id, NhaSanXuat NSX)
        {
            try
            {
                // TODO: Add update logic here
                NhaSanXuatBus.UpdateNSX(id, NSX);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //xóa tạm thời
        public ActionResult Remove(String id)
        {
            return View(NhaSanXuatBus.EditNSX(id));
        }
        [HttpPost]
        public ActionResult Remove(String id, NhaSanXuat NSX)
        {
            try
            {
                // TODO: Add delete logic here
                NSX.TinhTrang = 1;
                NhaSanXuatBus.UpdateNSX(id, NSX);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Admin/AdminNSX/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/AdminNSX/Delete/5
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
