using DOAN_WEB2.Models.BUS;
using MobileShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DOAN_WEB2.Models.BUS
{
    public class PhanLoaiBus
    {
        public static IEnumerable<LoaiSP> DanhSach()
        {
            var sql = new MobileShopConnectionDB();
            return sql.Query<LoaiSP>("select * from LoaiSP where TinhTrang = 0");

        }

        public static IEnumerable<SanPham> ChiTietPL(String id)
        {
            var sql = new MobileShopConnectionDB();
            return sql.Query<SanPham>("select * from SanPham where MaLoaiSP = '" + id + "'");
        }

        ////admin
        ////them
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
        public static LoaiSP EditLSP(String id)
        {
            var sql = new MobileShopConnectionDB();
            return sql.SingleOrDefault<LoaiSP>("select * from LoaiSP  where MaLoaiSP = '" + id + "'");
        }

        public static void UpdateLSP(String id, LoaiSP LSP)
        {
            var sql = new MobileShopConnectionDB();
            sql.Update(LSP, id);
        }
    }
}