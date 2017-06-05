using MobileShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOAN_WEB2.Models.BUS
{
    public class PhanLoaiBus
    {
        public static IEnumerable<LoaiSP> DanhSach()
        {
            var sql = new MobileShopConnectionDB();
            return sql.Query<LoaiSP>("select* from LoaiSP where TinhTrang = 0");

        }

        public static IEnumerable<SanPham> ChiTietPL(String id)
        {
            var sql = new MobileShopConnectionDB();
            return sql.Query<SanPham>("select * from SanPham where MaLoaiSP = '" + id + "'");
        }

        //admin
        //them
        public static IEnumerable<LoaiSP> DanhSanhLSPAdmin()
        {
            var sql = new MobileShopConnectionDB();
            return sql.Query<LoaiSP>("select * from LoaiSP ");
        }
        public static void ThemLSP(LoaiSP LSP)
        {
            var sql = new MobileShopConnectionDB();
            sql.Insert(LSP);
        }
        //EDIT
        public static IEnumerable<LoaiSP> EditLSP(String id)
        {
            var sql = new MobileShopConnectionDB();
            return sql.Query<LoaiSP>("select * from SanPham where MaLoaiSP = '" + id + "'");
        }


    }
}