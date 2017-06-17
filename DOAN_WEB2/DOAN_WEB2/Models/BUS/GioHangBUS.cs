using MobileShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOAN_WEB2.Models.BUS
{
    public class GioHangBUS
    {
        public static void Them(string masanpham, string mataikhoan, int gia, int soluong, string tensanpham)
        {
            using (var sql = new MobileShopConnectionDB())
            {
                var x = sql.Query<GioHang>("select * from GioHang Where MaTaiKhoan = '" + mataikhoan + "'and MaSP ='" + masanpham + "'").ToList();
                if (x.Count() > 0)
                {
                    //update so luong
                    int a = (int)x.ElementAt(0).SoLuong + soluong;
                    CapNhat(masanpham, mataikhoan, a, gia,tensanpham);
                }
                else
                {

                    GioHang giohang = new GioHang()
                    {
                        MaSP = masanpham,
                        MaTaiKhoan = mataikhoan,
                        Gia = gia,
                        SoLuong = soluong,
                        TenSP = tensanpham,
                        TongTien = gia * soluong
                    };
                    sql.Insert(giohang);
                }
            }
        }


        public static IEnumerable<GioHang> DanhSach(string mataikhoan)
        {
            using (var sql = new MobileShopConnectionDB())
            {
                return sql.Query<GioHang>("select * from GioHang where  MaTaiKhoan = '" + mataikhoan +"'");
            }
        }
        public static void CapNhat(string masanpham , string mataikhoan , int gia ,int soluong,string tensanpham )
        {
            using (var sql = new MobileShopConnectionDB())
            {
                GioHang giohang = new GioHang()
                {
                    MaSP = masanpham,
                    MaTaiKhoan = mataikhoan,
                    Gia = gia,
                    SoLuong = soluong,
                    TenSP = tensanpham,
                    TongTien = gia * soluong
                    
                };
                var tamp = sql.Query<GioHang>("select id from GioHang Where MaTaiKhoan = '" + mataikhoan + "'and MaSP ='" + masanpham + "'").FirstOrDefault();
                sql.Update(giohang, tamp.Id);
            }

        }
        public static void Xoa(string masanpham ,string mataikhoan)
        {
            using (var sql = new MobileShopConnectionDB())
            {
                var a = sql.Query<GioHang>("select * from GioHang Where MaTaiKhoan = '" + mataikhoan + "'and MaSP ='" + masanpham + "'").FirstOrDefault();
                sql.Delete(a);
            }
        }

        public static int TongTien(string mataikhoan)
        {
            using (var sql = new MobileShopConnectionDB())
            {
                return sql.Query<int>("select sum(TongTien) from GioHang where MaTaiKhoan = '" + mataikhoan + "'").FirstOrDefault();
            }
        }

    }
}