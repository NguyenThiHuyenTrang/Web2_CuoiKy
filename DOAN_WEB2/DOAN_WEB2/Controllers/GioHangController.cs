using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using DOAN_WEB2.Models.BUS;
using MobileShopConnection;

namespace WEB2_GK_demo.Controllers
{
    [Authorize]
    public class GioHangController : Controller
    {
        // GET: GioHang
        
        public ActionResult Index()
        {
            ViewBag.TongTien = GioHangBUS.TongTien(User.Identity.GetUserId());
            return View(GioHangBUS.DanhSach(User.Identity.GetUserId()));
        }

        [HttpPost]

        public ActionResult Them(string masanpham, string tensanpham, int gia, int soluong)
        {
            try
            {

                GioHangBUS.Them(masanpham, User.Identity.GetUserId(),gia,soluong,tensanpham);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("../Shop/Index");
            }
        }
        [HttpPost]

        public ActionResult CapNhat(string masanpham, string tensanpham, int gia, int soluong)
        {
            try
            {

                GioHangBUS.CapNhat(masanpham, User.Identity.GetUserId(), gia, soluong, tensanpham);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("../Shop/Index");
            }
        }

        [HttpGet]

        public ActionResult Xoa(string masanpham)
        {
            try
            {

                GioHangBUS.Xoa(masanpham, User.Identity.GetUserId());
                return RedirectToAction("index");
            }
            catch
            {
                return RedirectToAction("../Shop/index");
            }
        }
        //[HttpPost]
        //public ActionResult ThanhToan()
        //{

        //    IEnumerable<v_GioHang> dsCTGH = GioHangBUS.DanhSach(User.Identity.GetUserId());
        //    //int TongTien = 0;
        //    //foreach (var item in dsCTGH)
        //    //{
        //    //    TongTien += item.SoLuong * item.Gia;
        //    //}

        //    //tạo đơn hàng với MaTaiKhoan va tong tien

        //    //chuyen cac dong trong gio hang sang don hang
        //    //foreach(var item in dsCTGH)
        //    //{
        //    //    ChiTietDonHangBUS.Them(...)
        //    //}
        //    //xoa cac dong trong gio hang cua user 

        //    return RedirectToAction("Index");
        //}
    }
}