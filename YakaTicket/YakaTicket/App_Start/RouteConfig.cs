﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;

namespace YakaTicket
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Epita",
                url: "complete/epita/",
                defaults: new { controller = "Epita", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapHttpRoute(
                name: "AppliApi",
                routeTemplate: "api/{controller}/{id}/{e}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
