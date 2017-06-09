using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using DOAN_WEB2.Models.BUS;
using MobileShopConnection;

namespace DOAN_WEB2.Controllers
{
    public class GioHangController : Controller
    {
        // GET: GioHang
        [Authorize]
        public ActionResult Index()
        {
            return View(GioHangBUS.DanhSach(User.Identity.GetUserId()));
        }

        [HttpPost]

        public ActionResult Them(String maSanPham )
        {

            GioHangBUS.Them(maSanPham, User.Identity.GetUserId());
            return RedirectToAction("Index");
        }
        [HttpPost]

        public ActionResult CapNhat(int id, int soLuong)
        {

            GioHangBUS.CapNhat(id, soLuong);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult ThanhToan()
        {

            IEnumerable<v_GioHang> dsCTGH = GioHangBUS.DanhSach(User.Identity.GetUserId());
            //int TongTien = 0;
            //foreach (var item in dsCTGH)
            //{
            //    TongTien += item.SoLuong * item.Gia;
            //}

            //tạo đơn hàng với MaTaiKhoan va tong tien

            //chuyen cac dong trong gio hang sang don hang
            //foreach(var item in dsCTGH)
            //{
            //    ChiTietDonHangBUS.Them(...)
            //}
            //xoa cac dong trong gio hang cua user 

            return RedirectToAction("Index");
        }
    }
}