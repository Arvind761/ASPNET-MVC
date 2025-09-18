using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LabMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Params",
                url: "{controller}/{action}/{id}/{name}/{fee}",
                defaults: new { controller = "Params", action = "Index", id = UrlParameter.Optional,name=UrlParameter.Optional,fee=UrlParameter.Optional }

                );
            routes.MapRoute(
                name:"Employee",
                url: "{controller}/{action}/{id}",
                defaults: new {controller= "Employee", action="Test",id=UrlParameter.Optional}

                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
