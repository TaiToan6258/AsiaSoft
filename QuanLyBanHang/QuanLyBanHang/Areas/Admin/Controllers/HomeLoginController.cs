using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBanHang.Areas.Admin.Controllers
{
    public class HomeLoginController : BaseController
    {
        // GET: Admin/HomeLogin
        public ActionResult Index()
        {
            return View();
        }
    }
}