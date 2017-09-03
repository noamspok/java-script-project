﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Ex3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "GenerateApi",
                routeTemplate: "api/{controller}/{name}/{rows}/{cols}",
                defaults: new { controller = "Single" }
            );

            config.Routes.MapHttpRoute(
                name: "SolveApi",
                routeTemplate: "api/{controller}/{name}/{algo}",
                defaults: new { controller = "Single" }
            );

            config.Routes.MapHttpRoute(
                name: "RegisterApi",
                routeTemplate: "api/{controller}/{UserName}",
                defaults: new { controller = "Registery" }
            );
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
