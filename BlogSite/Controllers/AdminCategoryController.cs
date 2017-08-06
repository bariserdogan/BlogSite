using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminCategory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminCategory/Create
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

        // GET: AdminCategory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminCategory/Edit/5
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

        // GET: AdminCategory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminCategory/Delete/5
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
