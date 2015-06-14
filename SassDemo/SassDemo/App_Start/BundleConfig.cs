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

            var commonStylesBundle = new Bundle("~/Bundles/Styles");
            commonStylesBundle.Include(
                //               "~/Content/Fonts.css",
                //               "~/Content/Site.css",
                //               "~/Content/BundleTransformer.css",
                //               "~/AlternativeContent/css/TestCssComponentsPaths.css",
                //               "~/Content/themes/base/jquery.ui.core.css",
                //               "~/Content/themes/base/jquery.ui.theme.css",
                //               "~/Content/themes/base/jquery.ui.resizable.css",
                //               "~/Content/themes/base/jquery.ui.button.css",
                //               "~/Content/themes/base/jquery.ui.dialog.css",
                //               "~/Content/TestTranslators.css",
                //               "~/Content/less/TestLess.less",
                //               "~/Content/sass/TestSass.sass",
                "~/Content/Styles/Styles.scss");
            commonStylesBundle.Builder = nullBuilder;
            commonStylesBundle.Transforms.Add(styleTransformer);
            commonStylesBundle.Orderer = nullOrderer;
            bundles.Add(commonStylesBundle);

        }
    }
}