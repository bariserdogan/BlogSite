using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSite.Models;

namespace BlogSite.Controllers
{
    public class HomeController : Controller
    {
        BlogSite.Models.BlogSite db = new Models.BlogSite();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult ArticleinCategories(int? id)
        {
            var articles = from a in db.Articles
                             join c in db.Categories on a.CategoryID equals c.Category_id
                             select new
                             {
                                 a.Article_Content,
                                 a.Article_Date,
                                 a.Article_Foto,
                                 a.Article_Title,
                                 c.Category_Name
                             };
            if (articles == null)
                return HttpNotFound();                                    
            return View(articles);
        }
        public ActionResult CategoryPartial()
        {
            return View(db.Categories.ToList());
        }
    }
}