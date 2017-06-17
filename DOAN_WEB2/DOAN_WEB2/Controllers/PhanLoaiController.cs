using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOAN_WEB2.Models.BUS;

namespace DOAN_WEB2.Controllersz
{
    public class PhanLoaiController : Controller
    {
        // GET: Phanloai
        public ActionResult Index(String id, int PagedList = 1, int size = 6)
        {
            var sql = PhanLoaiBus.ChiTietPL(id).ToPagedList(PagedList, size);
            return View(sql);

        }
    }

}