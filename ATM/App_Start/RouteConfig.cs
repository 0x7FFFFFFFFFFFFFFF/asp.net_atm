﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ATM
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Serial number",
                url: "serial/{letterCase}",
                defaults: new { controller = "Home", action = "Serial", letterCase = "upper" }
            );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                // If controller and action were not specified, then use below default info
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



        }
    }
}
