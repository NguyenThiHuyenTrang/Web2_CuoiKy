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
            return sql.Query<SanPham>("select * from SanPham where TinhTrang != 1    ");

        }

        public static IEnumerable<SanPham> DanhSachTOP10()
        {
            var sql = new MobileShopConnectionDB();
            return sql.Query<SanPham>(" SELECT TOP 10  * FROM SanPham WHERE TinhTrang = 0 ORDER BY SoLuongBan DESC");

        }

        public static SanPham ChiTiet(String id)
        {
            var sql = new MobileShopConnectionDB();
            return sql.SingleOrDefault<SanPham>("select * from SanPham where MaSP = @0", id);
        }
        public static IEnumerable<SanPham> DanhSachSP()
        {
            var sql = new MobileShopConnectionDB();
            return sql.Query<SanPham>("select * from SanPham ");

        }
        public static void ThemSP(SanPham sp)
        {
            var sql = new MobileShopConnectionDB();
            sql.Insert(sp);

        }

        public static void SuaSanPham(string id, MobileShopConnection.SanPham sp)
        {
            var db = new MobileShopConnectionDB();

            db.Update<SanPham>("SET TenSP=@0, MoTa=@1, MaNhaSX=@2, Gia=@3, HeDieuHanh=@4, HinhChinh=@5, ManHinh=@6, RAM=@7, CameraSau=@8, CameraTruoc=@9, MaLoaiSP=@10, BoNhoTrong=@11, TinhTrang=@12 where MaSanPham=@13", sp.TenSP, sp.MoTa, sp.MaNhaSX, sp.Gia, sp.HeDieuHanh, sp.HinhChinh, sp.ManHinh, sp.RAM, sp.CameraSau, sp.CameraTruoc, sp.MaLoaiSP, sp.BoNhoTrong, sp.TinhTrang , id);
        }

        public static void XoaTamSanPham(string id)
        {
            var db = new MobileShopConnectionDB();

            db.Update<SanPham>("SET TinhTrang=1 where MaSP=@0", id);
            }
        public static SanPham LoadAvartaImg(String id)
        {
            var sql = new MobileShopConnectionDB();
            return sql.SingleOrDefault<SanPham>("select * from SanPham where MaSP = @0", id);
        }
    }
}