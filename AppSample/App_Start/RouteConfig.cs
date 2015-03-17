using System.Web.Mvc;
using System.Web.Routing;

namespace AppSample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Page 0", "Sample/", new { controller = "Sample", action = "Index" });
            routes.MapRoute("Page 1", "Sample/Page1", new { controller = "Sample", action = "Index" });
            routes.MapRoute("Page 2", "Sample/Page2", new { controller = "Sample", action = "Index" });
            routes.MapRoute("Page 3", "Sample/Page3", new { controller = "Sample", action = "Index" });
            routes.MapRoute("Page 4", "Sample/Page4", new { controller = "Sample", action = "Index" });
            routes.MapRoute("Page 5", "Sample/Page5", new { controller = "Sample", action = "Index" });
            routes.MapRoute("Page 6", "Sample/Page6", new { controller = "Sample", action = "Index" });
            routes.MapRoute("Page 7", "Sample/Page7", new { controller = "Sample", action = "Index" });
            routes.MapRoute("Page 8", "Sample/Page8", new { controller = "Sample", action = "Index" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
