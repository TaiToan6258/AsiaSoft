using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using QuanLyBanHang.Areas.Admin.Data;
using QuanLyBanHang.Common;

namespace QuanLyBanHang.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginData data)
        {
            if (ModelState.IsValid)
            {
                var userdao = new UserDao();
                var result = userdao.CheckLogin(data.UserName, Encryptor.MD5Hash(data.Password));
                switch (result)
                {
                    // dont exits
                    case 0:
                        ModelState.AddModelError("", "Tai Khoan Khong Ton Tai ");
                        break;
                    // exits and add to session
                    case 1:

                        var client = userdao.GetByUser(data.UserName);
                        var userSession = new user();
                        userSession.Name = client.Username;
                        userSession.UserId = client.Id;

                        Session.Add(ConstantsCommon.USER_SESSION, userSession);
                        return RedirectToAction("Index", "HomeLogin");
                    // wrong password
                    case -1:
                        ModelState.AddModelError("", "Sai Mat Khau");
                        break;

                }
            }
           
                return View("Index");
      
        }
    }
}