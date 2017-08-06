using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class AdminArticleController : Controller
    {
        BlogSite.Models.BlogSite db = new Models.BlogSite();
        // GET: AdminArticle
        public ActionResult Index()
        {
            return View(db.Articles.ToList());
        }

        // GET: AdminArticle/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminArticle/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Category_id", "Category_Name");
            return View();
        }

        // POST: AdminArticle/Create
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

        // GET: AdminArticle/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminArticle/Edit/5
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

        // GET: AdminArticle/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminArticle/Delete/5
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
