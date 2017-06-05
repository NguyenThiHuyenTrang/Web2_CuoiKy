using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOAN_WEB2.Models.BUS;

namespace DOAN_WEB2.Controllers
{
    public class NhaSanXuatController : Controller
    {
        // GET: NhaSanXuat
        public ActionResult Index(String id, int PagedList = 1, int size = 6)
        {
            var sql = NhaSanXuatBus.ChiTietNSX(id).ToPagedList(PagedList, size);
            return View(sql);

        }
    }
}