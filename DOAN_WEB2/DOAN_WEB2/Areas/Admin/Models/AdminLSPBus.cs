using MobileShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOAN_WEB2.Areas.Admin.Models
{
    public class AdminLSPBus
    {
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