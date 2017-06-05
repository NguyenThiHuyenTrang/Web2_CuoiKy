using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB2_GK_demo.Models.BUS;

namespace WEB2_GK_demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int PagedList = 1, int size = 3)
        {
            var sql = MobileShopBus.DanhSach().ToPagedList(PagedList, size);
            return View(sql);
        }
        public ActionResult Details(String id)
        {
            var sql = MobileShopBus.ChiTiet(id);
            return View(sql);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}