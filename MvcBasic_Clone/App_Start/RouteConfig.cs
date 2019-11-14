using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcBasic_Clone
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //路由會忽略掉WebResourse
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "MacRoute",
             url: "Mac",
             defaults: new { controller = "Mac", action = "MacPage", id = UrlParameter.Optional }
         );
            routes.MapRoute(
             name: "IPhoneRoute",
             url: "IPhone",
             defaults: new { controller = "IPhone", action = "IPhonePage", id = UrlParameter.Optional }
         );
            routes.MapRoute(
             name: "IPadRoute",
             url: "IPad",
             defaults: new { controller = "IPad", action = "IPadPage", id = UrlParameter.Optional }
         );
               routes.MapRoute(
                name: "iWatchRoute",
                url: "iWatch",
                defaults: new { controller = "iWatch", action = "iWatchPage", id = UrlParameter.Optional }
            );
          
            routes.MapRoute(
                name:"FriendRoute",
                url:"Friend",
                defaults: new {controller="Friends",action="index",id=UrlParameter.Optional}
                );
            routes.MapRoute(
               name: "EmployeeRoute",
               url: "Employee",
               defaults: new { controller = "Employee", action = "index", id = UrlParameter.Optional }
               );
            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          );
        }
    }
}
