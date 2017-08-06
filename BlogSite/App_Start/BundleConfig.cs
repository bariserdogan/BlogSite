using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BlogSite.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.

            bundles.Add(new ScriptBundle("~/Js").Include(
                      "~/Content/plugins/jQuery/jquery-2.2.3.min.js",
                      "~/Content/bootstrap/js/bootstrap.min.js",
                      "~/Content/plugins/slimScroll/jquery.slimscroll.min.js",
                      "~/Content/plugins/fastclick/fastclick.js",
                      "~/Content/dist/js/app.min.js",
                      "~/Content/dist/js/demo.js"
                      )); 
            bundles.Add(new ScriptBundle("~/BlogJs").Include(
                    "~/Content/homeJs/bootstrap.min.js",
                    "~/Content/homeJs/jquery.js"
                      ));

            bundles.Add(new StyleBundle("~/Css").Include(
                      "~/Content/bootstrap/css/bootstrap.min.css",
                      "~/Content/dist/css/AdminLTE.min.css",
                      "~/Content/dist/css/skins/_all-skins.min.css"
                      ));

            bundles.Add(new StyleBundle("~/BlogCss").Include(
                    "~/Content/homeCss/bootstrap.min.css",
                    "~/Content/homeCss/blog-home.css"
                ));
           

            BundleTable.EnableOptimizations = true;
        }
    }
}