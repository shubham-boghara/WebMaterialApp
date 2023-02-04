using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebMaterialApp.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bs-jq-bundle").Include(
                          "~/Content/plugins/jquery/jquery.min.js",
                          "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js",
                          "~/Content/dist/js/adminlte.min.js"
                          ));

            var font_cdn = "https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback";

            bundles.Add(new StyleBundle("~/bundles/css",font_cdn).Include(
                                                    "~/Content/plugins/fontawesome-free/css/all.min.css",
                                                    "~/Content/dist/css/adminlte.min.css"
                                                ));
           
            //the following creates bundles in debug mode;
            //BundleTable.EnableOptimizations = true;
        }
    }
}