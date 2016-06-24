using System.Web;
using System.Web.Optimization;

namespace TutorConnect
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            


            bundles.Add(new ScriptBundle("~/bundles/tutorconnect").Include(
                        "~/js/jquery.js", "~/query.easing.1.3.js",
                        "~/js/bootstrap.min.js", "~/js/jquery.fancybox.pack.js",
                        "~/js/jquery.fancybox-media.js", "~/js/portfolio/jquery.quicksand.js",
                        "~/js/portfolio/setting.js", "~/js/jquery.flexslider.js",
                        "~/js/animate.js", "~/js/custom.js", "~/js/owl-carousel/owl.carousel.js"));
           
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/js/angular.js", "~/js/angular-route.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/css/bootstrap.min.css",
                    "~/css/fancybox/jquery.fancybox.css",
                    "~/css/jcarousel.css",
                    "~/css/flexslider.css",
                    "~/js/owl-carousel/owl.carousel.css",
                    "~/css/style.css"));
           

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
