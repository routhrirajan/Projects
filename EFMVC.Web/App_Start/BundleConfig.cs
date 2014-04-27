using System.Web.Optimization;

namespace EFMVC.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Force optimization to be on or off, regardless of web.config setting
            //BundleTable.EnableOptimizations = false;
            bundles.UseCdn = false;
       
            // .debug.js, -vsdoc.js and .intellisense.js files 
            // are in BundleTable.Bundles.IgnoreList by default.
            // Clear out the list and add back the ones we want to ignore.
            // Don't add back .debug.js.
            bundles.IgnoreList.Clear();
            bundles.IgnoreList.Ignore("*-vsdoc.js");
            bundles.IgnoreList.Ignore("*intellisense.js");
            bundles.IgnoreList.Ignore("*start-menu.js");
            // Modernizr goes separate since it loads first
            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/lib/modernizr-{version}.js"));

            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery", 
                "//ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js")
                .Include("~/Scripts/lib/jquery-{version}.js"));

            // All assets JS files 
            bundles.Add(new ScriptBundle("~/bundles/jsassets")
                .IncludeDirectory("~/Scripts/assets/", "*.js", searchSubdirectories: false));

            // All metro JS files 
            bundles.Add(new ScriptBundle("~/bundles/jsmetro")
                .IncludeDirectory("~/Scripts/metro/", "*.js", searchSubdirectories: false));

            // 3rd Party CSS files
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/boilerplate-styles.css",
                "~/Content/metroui/modern.css",
                "~/Content/metroui/modern-responsive.css",
                "~/Content/metroui/site.css",
                "~/Content/toastr.css"));
            
        }
    }
}