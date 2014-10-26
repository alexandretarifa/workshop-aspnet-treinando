using System.Web;
using System.Web.Optimization;

namespace BundleMinification
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundle/css")
                .Include("~/content/site.css")
                .Include("~/Content/themes/base/jquery.ui.accordion.css")
                .Include("~/Content/themes/base/jquery.ui.autocomplete.css")
                .Include("~/Content/themes/base/jquery.ui.button.css")
                .Include("~/Content/themes/base/jquery.ui.core.css")
                .Include("~/Content/themes/base/jquery.ui.datepicker.css")
                .Include("~/Content/themes/base/jquery.ui.dialog.css")
                .Include("~/Content/themes/base/jquery.ui.progressbar.css")
                .Include("~/Content/themes/base/jquery.ui.resizable.css")
                .Include("~/Content/themes/base/jquery.ui.selectable.css")
                .Include("~/Content/themes/base/jquery.ui.slider.css")
                .Include("~/Content/themes/base/jquery.ui.tabs.css" )
                .Include("~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery")
                  .Include("~/Scripts/jquery-{version}.js")
                  .Include("~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                        .Include("~/Scripts/modernizr-*"));
        }
    }
}