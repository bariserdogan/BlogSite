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
        public ActionResult CategoryPartial()
        {
            return View(db.Categories.ToList());
        }
    }
}