using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using model.Dao;
using NortwindTradersManagerment.Areas.Admin.Data.QuanLyBanHang.Areas.Admin.Data;
using NortwindTradersManagerment.Common;
 


namespace NortwindTradersManagerment.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {   
            var res = new UserDao().Login(model.username, model.password);
            if (ModelState.IsValid)
            {
                if (res == true) {
                    SesstionHelper.SetSession(new UserSession() 
                    { username = model.username });
                    return RedirectToAction("Index", "Dashbroad");
                }
            }
            ModelState.AddModelError("", "Username or Password Wrong !!!");

            return View();
        }
    }
}