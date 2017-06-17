using Microsoft.AspNet.Identity;
using System;
using PagedList;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOAN_WEB2.Models.BUS;

namespace DOAN_WEB2.Controllers
{
    public class BinhLuanController : Controller
    {
        // GET: BinhLuan
        [Authorize]
        public ActionResult Create(String MaSanPham, String NoiDung)
        {

            BinhLuanBUS.Them(MaSanPham, User.Identity.GetUserId(), User.Identity.Name, NoiDung);
            return RedirectToAction("Details", "Shop", new { Id = MaSanPham });
        }

        public ActionResult Index(string MaSP, int PagedList = 1, int size = 6)
        {
            ViewBag.MaSP = MaSP;
            return View(BinhLuanBUS.DanhSach(MaSP).ToPagedList(PagedList, size));
        }
    }
}