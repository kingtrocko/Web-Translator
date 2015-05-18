using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebTranslator
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    "TranslateLanguages",                                           // Route name
            //    "Translate/x/{source}/{target}",                          // URL with parameters
            //    new { controller = "Translate", action = "Translate" }  // Parameter defaults
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Translate", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
