using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOAN_WEB2.Models.BUS;
using PagedList.Mvc;
using PagedList;
using MobileShopConnection;
using System.Data.Entity;
using DOAN_WEB2.Models;

namespace DOAN_WEB2.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search

       
        [HttpGet]
        public ActionResult Index(string searchString,int page = 1 , int pageSize = 5)
        {

           
            var model = SearchBUS.Search(searchString).ToPagedList(page,pageSize);
            return View(model);       
        }
    }
}