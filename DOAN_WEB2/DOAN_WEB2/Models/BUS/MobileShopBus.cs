using MobileShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOAN_WEB2.Models.BUS
{
    public class MobileShopBus
    {
        public static IEnumerable<SanPham> DanhSach()
        {
            var sql = new MobileShopConnectionDB();
            return sql.Query<SanPham>("select* from SanPham where TinhTrang = 0");

        }
        public static SanPham ChiTiet(String id)
        {
            var sql = new MobileShopConnectionDB();
            return sql.SingleOrDefault<SanPham>("select * from SanPham where MaSP = @0", id);
        }
        public static IEnumerable<SanPham> DanhSachSP()
        {
            var sql = new MobileShopConnectionDB();
            return sql.Query<SanPham>("select* from SanPham ");

        }
        public static void ThemSP(SanPham sp)
        {
            var sql = new MobileShopConnectionDB();
            sql.Insert(sp);

        }
        public static SanPham LoadAvartaImg(String id)
        {
            var sql = new MobileShopConnectionDB();
            return sql.SingleOrDefault<SanPham>("select * from SanPham where MaSP = @0", id);
        }
    }
}