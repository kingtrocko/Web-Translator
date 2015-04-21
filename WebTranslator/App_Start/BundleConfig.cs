using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebTranslator.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Content/css").Include(
                "~/Content/skel.css",
                "~/Content/style.css",
                "~/Content/style-desktop.css"
                ));

            bundles.Add(new ScriptBundle("~/Scripts/js").Include(
                "~/Scripts/jquery.min.js",
                "~/Scripts/jquery.dropotron.min.js",
                "~/Scripts/skel.min.js",
                "~/Scripts/skel-layers.min.js",
                "~/Scripts/init.js"
                ));

            bundles.Add(new ScriptBundle("~/Scripts/swagger").Include(
                "~/Scripts/swagger-client.js"));

            BundleTable.EnableOptimizations = false;
        }
    }
}