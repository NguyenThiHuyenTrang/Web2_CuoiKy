using MobileShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOAN_WEB2.Models.BUS
{
    public class GioHangBUS
    {
        public static void Them(string maSanPham, string maTaiKhoan  )
        {
            using (var sql = new MobileShopConnectionDB())
            {

                GioHang gioHang = new GioHang()
                {
                    MaSP = maSanPham,
                    MaTaiKhoan = maTaiKhoan,
                  
                   
                    SoLuong = 1
                };
                sql.Insert(gioHang);
            }
        }
        public static IEnumerable<v_GioHang> DanhSach(string maTaiKhoan)
        {
            using (var sql = new MobileShopConnectionDB())
            {
                return sql.Query<v_GioHang>("select * from v_GioHang where  MaTaiKhoan = @0", maTaiKhoan);
            }
        }
        public static void CapNhat(int id, int soLuong)
        {
            using (var sql = new MobileShopConnectionDB())
            {
                sql.Execute("update giohang set [SoLuong] = @0 where id = @1", soLuong, id);
            }

        }
    }
}