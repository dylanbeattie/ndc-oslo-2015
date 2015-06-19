using System.Web.Optimization;
using BundleTransformer.Core.Builders;
using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Transformers;

namespace SassDemo {
    public class BundleConfig {
        public static void RegisterBundles(BundleCollection bundles) {
            var nullBuilder = new NullBuilder();
            var styleTransformer = new StyleTransformer();
            var scriptTransformer = new ScriptTransformer();
            var nullOrderer = new NullOrderer();

            var commonStylesBundle = new Bundle("~/bundles/styles");
            commonStylesBundle.Include("~/Content/Styles/Styles.scss");
            commonStylesBundle.Builder = nullBuilder;
            commonStylesBundle.Transforms.Add(styleTransformer);
            commonStylesBundle.Orderer = nullOrderer;
            bundles.Add(commonStylesBundle);


            var scriptsBundle = new Bundle("~/bundles/scripts/examples");
            scriptsBundle.Include(
                "~/Content/Scripts/greeting.coffee",
                "~/Content/Scripts/greeting.ts"
                );
            scriptsBundle.Builder = nullBuilder;
            scriptsBundle.Transforms.Add(scriptTransformer);
            scriptsBundle.Orderer = nullOrderer;
            bundles.Add(scriptsBundle);

            var jQueryBundle = new Bundle("~/bundles/scripts/jquery");  
            jQueryBundle.Include("~/scripts/jquery-2.1.4.js");
            bundles.Add(jQueryBundle);


        }
    }
}