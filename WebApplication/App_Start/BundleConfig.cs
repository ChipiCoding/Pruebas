﻿using System.Web.Optimization;

namespace WebApplication
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/App")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .Include("~/Scripts/Module.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
