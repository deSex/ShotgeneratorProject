using System.Web.Optimization;

namespace ShotgeneratorProject
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts")
                .Include("~/bower_components/jquery/dist/jquery.min.js")
                .Include("~/bower_components/bootstrap/dist/js/bootstrap.min.js")
                .Include("~/bower_components/angular/angular.min.js")
                .IncludeDirectory("~/Scripts/app", "*.js", true));


            bundles.Add(new StyleBundle("~/bundles/styles")
                .Include("~/bower_components/bootstrap/dist/css/bootstrap.min.css")
                .Include("~/static/css/shotgenerator.css"));

        }
        
    }
}