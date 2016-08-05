using System.Web;
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
               "~/bower_components/angular-route/angular-route.js",
               "~/bower_components/jquery/dist/jquery.js",
               "~/bower_components/bootstrap/dist/js/bootstrap.js"
               ).IncludeDirectory("~/scripts/app", "*.js", true));

            bundles.Add(new StyleBundle("~/styles/").Include(
                "~/styles/main.css",
                "~/styles/bootstrap.min.css"
                ));
        }
    }
}
