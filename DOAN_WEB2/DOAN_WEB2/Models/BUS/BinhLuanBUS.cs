using MobileShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOAN_WEB2.Models.BUS
{
    public class BinhLuanBUS
    {
        public static void Them(string MaSP, string MaTaiKhoan, string TenTaiKhoan, string NoiDung)
        {
            using (var sql = new MobileShopConnectionDB())
            {
                BinhLuan binhLuan = new BinhLuan();
                binhLuan.MaSP = MaSP;
                binhLuan.MaTaiKhoan = MaTaiKhoan;
                binhLuan.NoiDung = NoiDung;
                sql.Execute("INSERT INTO [dbo].[BinhLuan]([MaSP],[MaTaiKhoan],[TenTaiKhoan],[NoiDung]) VALUES (@0,@1,@2,@3)", MaSP, MaTaiKhoan, TenTaiKhoan, NoiDung);
            }
        }
        public static IEnumerable<BinhLuan> DanhSach(String MaSP)
        {
            using (var sql = new MobileShopConnectionDB())
            {
                return sql.Query<BinhLuan>(" select * from BinhLuan  where MaSP = @0 ORDER BY Ngay DESC", MaSP);
            }
        }
    }
}