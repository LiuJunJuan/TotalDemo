using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebSocketDemo.WebSocketFile;

namespace WebSocketDemo.Models
{
    public class PlainRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new WebsocketHandler.Handler1();
        }

    }


    public class Handler : MvcRouteHandler
    {
        protected override IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return base.GetHttpHandler(requestContext);
        }

    }
}