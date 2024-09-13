using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;
using PagedList;
using QuanLyBanHang.Common;

namespace QuanLyBanHang.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Index(int page = 1, int pageSize = 1)
        {   
            var dao = new UserDao();
            var model = dao.ListAllpaging(page, pageSize);  
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UserInfo user)
        {
            // Chech form
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var encrytorMD5 = Encryptor.MD5Hash(user.PassWord);
                user.PassWord = encrytorMD5;
                long id = dao.Insert(user);
                if (id > 0)
                {
                    return RedirectToAction("Index", "User");
                }
            }
            else {
                ModelState.AddModelError("", "Them User Khong Thanh Cong");
            }

            return View();

        }
    }
}