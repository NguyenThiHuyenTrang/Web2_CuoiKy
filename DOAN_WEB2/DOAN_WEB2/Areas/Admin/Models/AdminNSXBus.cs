using MobileShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOAN_WEB2.Areas.Admin.Models
{
    public class AdminNSXBus
    {
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