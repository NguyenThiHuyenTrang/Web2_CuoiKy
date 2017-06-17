using MobileShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOAN_WEB2.Areas.Admin.Models
{
    public class AdminSPBus
    {
        public static IEnumerable<SanPham> DanhSachSanPham()
        {
            var sql = new MobileShopConnectionDB();
            return sql.Query<SanPham>("select * from SanPham where TinhTrang=0");
        }

        public static void Them(SanPham sx)
        {
            var sql = new MobileShopConnectionDB();
            sql.Insert(sql);
        }

        //public static IEnumerable<LoaiSanPham> LDS()
        //{
        //    using (var db = new DoAnGiuaKiConnectionDB())
        //    {
        //        return db.Query<DoAnGiuaKiConnection.LoaiSanPham>("select * from LoaiSanPham where TinhTrang = 0");
        //    }
        //}
    }
}