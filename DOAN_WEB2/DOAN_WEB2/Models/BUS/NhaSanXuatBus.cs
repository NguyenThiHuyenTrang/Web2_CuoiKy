using MobileShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOAN_WEB2.Models.BUS
{
    public class NhaSanXuatBus
    {
        public static IEnumerable<NhaSanXuat> DanhSach()
        {
            var sql = new MobileShopConnectionDB();
            return sql.Query<NhaSanXuat>("select*  from NhaSanXuat where TinhTrang = 0");

        }
        public static IEnumerable<SanPham> ChiTietNSX(String id)
        {
            var sql = new MobileShopConnectionDB();
            return sql.Query<SanPham>("select * from SanPham where MaNhaSX = '" + id + "'");
        }
        //admin
        //them
        public static IEnumerable<NhaSanXuat> DanhSanhNSXAdmin()
        {
            var sql = new MobileShopConnectionDB();
            return sql.Query<NhaSanXuat>("select * from NhaSanXuat ");
        }
        public static void ThemNSX(NhaSanXuat NSX)
        {
            var sql = new MobileShopConnectionDB();
            sql.Insert(NSX);
        }
        //edit
        public static NhaSanXuat EditNSX(String id)
        {
            var sql = new MobileShopConnectionDB();
            return sql.SingleOrDefault<NhaSanXuat>("select * from NhaSanXuat where MaNhaSX = '" + id + "'");
        }
        public static void UpdateNSX(String id, NhaSanXuat NSX)
        {
            var sql = new MobileShopConnectionDB();
            sql.Update(NSX, id);
        }

    }
}