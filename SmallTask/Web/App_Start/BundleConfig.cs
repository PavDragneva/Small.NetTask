namespace SmallTask.Web.App_Start
{
    using System.Web;
    using System.Web.Optimization;

        public class BundleConfig
        {
            // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
            public static void RegisterBundles(BundleCollection bundles)
            {
                bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                            "~/Scripts/jquery-{version}.js",
                            "~/Scripts/bootstrap.min.js",
                            "~/Scripts/bootstrap-toggle.js"
                            ));

                bundles.Add(new ScriptBundle("~/bundles/myScripts").Include(
                            "~/Scripts/App/user-buttons.js"
                            ));

                bundles.Add(new StyleBundle("~/Content/css").Include(
                          "~/Content/bootstrap.css",
                          "~/Content/font-awesome.css"
                          ));
            }
        }
    }