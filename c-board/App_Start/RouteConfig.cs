using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;
using c_board.Models.Routing;

namespace c_board
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Add(new Route("foo/{shop_code}/{*action}", new fooRouteHandler("~/foo/{action}.aspx")));
            routes.EnableFriendlyUrls();
        }
    }
}
