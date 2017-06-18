using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using MobileShopConnection;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PagedList;

namespace DOAN_WEB2.Models.BUS
{

    public class SearchBUS
    {
        
        public static IEnumerable<SanPham> Search (string searchString)//, int page, int pageSize )
        {
            //var db = new MobileShopConnectionDB();
            //IQueryable<SanPham> model = db.SanPhams;
            ////IObs<SanPham> model = db.Query<SanPham>("select * from SanPham where TenSP Like '%" + searchString + "%'").ToList();
            ////var text = db.Query<SanPham>("select * from SanPham where TenSP Like '%" + searchString + "%'");

            //if (!string.IsNullOrEmpty(searchString))
            //{
            //    model = model.Where(x => x.TenSP.Contains(searchString) || x.MoTa.Contains(searchString)).OrderByDescending(x => x.MaSP);
            //    //text = text.Where(s => s.TenSP.Contains(searchString)).ToList();
            //}
            //return model.ToPagedList(page, pageSize);
            var db = new MobileShopConnectionDB();
            return db.Query<SanPham>("Select * From SanPham Where TenSP like '%"+searchString+ "%' or Ram like '%" + searchString + "%' or Gia like '%" + searchString + "%' or SoLuongBan like '%" + searchString + "%' or HeDieuHanh like '%" + searchString + "%' or BoNhoTrong like '%" + searchString + "%' or CameraTruoc like '%" + searchString + "%' or CameraSau like '%" + searchString + "%'  or TheNho like '%" + searchString + "%'");
          

        }

       
    }
}