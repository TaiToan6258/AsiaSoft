using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NortwindTradersManagerment.Areas.Admin.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Admin/Customers
        public ActionResult Index()
        {
            var model = new CustomersModel().ListAll();
            return View(model);
        }

        // GET: Admin/Customers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Customers/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Customers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Customers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Customers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
