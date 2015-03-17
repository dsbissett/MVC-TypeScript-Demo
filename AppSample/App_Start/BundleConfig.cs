using System;
using System.IO;
using System.Web;
using System.Web.Hosting;
using System.Web.Optimization;

namespace AppSample.App_Start
{
    public class BundleConfig
    {
        private const string AdminAppDir = "App";

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            AddDefaultIgnorePatterns(bundles.IgnoreList);

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular/angular.js",
                        "~/Scripts/angular/angular-route.js",
                        "~/Scripts/angular/angular-messages.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap/bootstrap.js",
                      "~/Scripts/respond/respond.js"));

            bundles.Add(new StyleBundle("~/css").Include("~/Content/bootstrap/bootstrap.css", "~/Content/Site.css"));


            AddApplicationBundles(bundles);

            BundleTable.VirtualPathProvider = new ScriptBundlePathProvider(HostingEnvironment.VirtualPathProvider);

            BundleTable.EnableOptimizations = true;
        }

        #region  ///  ScriptBundlePathProvider  ///
        private class ScriptBundlePathProvider : VirtualPathProvider
        {
            private readonly VirtualPathProvider _virtualPathProvider;

            public ScriptBundlePathProvider(VirtualPathProvider virtualPathProvider)
            {
                _virtualPathProvider = virtualPathProvider;
            }

            public override bool FileExists(string virtualPath)
            {
                return _virtualPathProvider.FileExists(virtualPath);
            }

            public override VirtualFile GetFile(string virtualPath)
            {
                return _virtualPathProvider.GetFile(virtualPath);
            }

            public override VirtualDirectory GetDirectory(string virtualDir)
            {
                return _virtualPathProvider.GetDirectory(virtualDir);
            }

            public override bool DirectoryExists(string virtualDir)
            {
                return _virtualPathProvider.DirectoryExists(virtualDir);
            }
        }
        #endregion

        #region  ///  AddDefaultIgnorePatterns  ///
        public static void AddDefaultIgnorePatterns(IgnoreList ignoreList)
        {
            if (ignoreList == null)
            {
                throw new ArgumentNullException("ignoreList");

            }

            ignoreList.Ignore("*.intellisense.js");
            ignoreList.Ignore("*-vsdoc.js");
            ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
            ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
        }
        #endregion

        #region  ///  AddApplicationBundles  ///
        private static void AddApplicationBundles(BundleCollection bundles)
        {
            var scriptBundle = new ScriptBundle("~/bundles/app");
            var adminAppDirFullPath = HttpContext.Current.Server.MapPath(string.Format("~/{0}", AdminAppDir));
            if (Directory.Exists(adminAppDirFullPath))
            {
                scriptBundle.Include(
                    //  Order matters, so get the core app setup first..
                    //---------------------------------------------------
                    string.Format("~/{0}/app.module.js", AdminAppDir),
                    string.Format("~/{0}/app.core.module.js", AdminAppDir))

                    //  then get any other top level js files..
                    //---------------------------------------------------
                    .IncludeDirectory(string.Format("~/{0}", AdminAppDir), "*.js", false)

                    //  then get all nested module js files..
                    //---------------------------------------------------
                    .IncludeDirectory(string.Format("~/{0}", AdminAppDir), "*.module.js", true)

                    //  finally, get all the other js files
                    //---------------------------------------------------
                    .IncludeDirectory(string.Format("~/{0}", AdminAppDir), "*.js", true);
            }
            bundles.Add(scriptBundle);
            //bundles.Add(new StyleBundle("~/app-styles").Include(
            //    "~/Content/css/site.css"));
        }
        #endregion
    }
}