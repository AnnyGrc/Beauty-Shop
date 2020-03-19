using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BeautyShop.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundle)
        {
            bundle.Add(new StyleBundle("~/bundles/bootstrap/css").
                Include("~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundle.Add(new ScriptBundle("~/bundles/bootstrap/js").
                Include("~/Scripts/bootstrap.min.js"));
            bundle.Add(new ScriptBundle("~/bundles/jquery/js").
                Include("~/Scripts/jquery-3.4.1.min.js"));

            bundle.Add(new ScriptBundle("~/bundles/main/js").
                Include("~/Scripts/mainlogic.js"));

            bundle.Add(new StyleBundle("~/bundles/main/css").
                Include("~/Content/style.css", new CssRewriteUrlTransform()));
        }
    }
}