using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebSocketDemo.Models;

namespace WebSocketDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            //routes.Add("socket",new Route(
            //    "socket/{controller}/{action}/{id}",
            //    new RouteValueDictionary(new
            //    {
            //        controller = "Account",
            //        action = "Logon",
            //        id = UrlParameter.Optional
            //    }),
            //    new PlainRouteHandler()));

            routes.Add("socket",
                new Route("socket", new PlainRouteHandler()));

            routes.Add(new Route(
                "{controller}/{action}/{id}",
                new RouteValueDictionary(new
                {
                    controller = "Account",
                    action = "Logon",
                    id = UrlParameter.Optional
                }),
                new MvcRouteHandler()));


          
        }
    }
}
