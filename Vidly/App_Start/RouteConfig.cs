﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Enabling attribute routing
            routes.MapMvcAttributeRoutes();

            // Custom route
            routes.MapRoute(
                name: "MoviesByReleaseDate",
                url: "movies/byreleasedate/{year}/{month}",
                defaults: new {controller = "Movies", action = "ByReleaseDate"},
                constraints: new {year = @"\d{4}", month = @"1|2|3|4|5|6|7|8|9|10|11|12"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
