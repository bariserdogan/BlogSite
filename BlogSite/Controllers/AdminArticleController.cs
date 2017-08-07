using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
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
        public ActionResult Create(BlogSite.Models.Article model,string tags,HttpPostedFile photo)
        {
            try
            {
                if(photo!=null)
                {
                    WebImage image = new WebImage(photo.InputStream);
                    FileInfo _photoinfo = new FileInfo(photo.FileName); // path bilgisi

                    string newPhoto = Guid.NewGuid().ToString() + _photoinfo.Extension; // resmin uzantısını aldık
                    image.Resize(800, 350); // resmi yeniden boyutlandırsın
                    image.Save("~/Uploads/ArticlePhotos/" + newPhoto); // resimler için bir klasör oluştur ve ekle
                    model.Article_Foto = "~/Uploads/ArticlePhotos/" + newPhoto;
                    db.Articles.Add(model);
                    
                }
                if(tags!=null)
                {
                    string[] tagsArray = tags.Split(',');
                    foreach (var item in tagsArray)
                    {
                        var yenietiket = new BlogSite.Models.Tag { Tag_Name = item };
                        db.Tags.Add(yenietiket);
                        model.Tags.Add(yenietiket);
                    }
                }
                db.SaveChanges();           

                System.Threading.Thread.Sleep(2000);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
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
