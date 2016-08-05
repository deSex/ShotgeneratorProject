﻿using System.Web;
using System.Web.Optimization;

namespace ShotgeneratorProject.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/scripts/").Include(
               "~/bower_components/angular/angular.js",
               "~/bower_components/angular-ui-router/release/angular-ui-router.js",
               "~/bower_components/jquery/dist/jquery.js",
               "~/bower_components/bootstrap/dist/js/bootstrap.js",
               "~/scripts/app/app.js"
               ));
            bundles.Add(new StyleBundle("~/styles/").Include(
                "~/bower_components/bootstrap/dist/css/bootstrap.css",
                "~/styles/main.css"
                ));
        }
    }
}
