using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace interview1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            
            routes.MapRoute(                                            // Route name
              "BooksDetail",                                              // Route name
              "books/detail/{section}",                           // URL with parameters
              new { controller = "Home", action = "bookDetail" }  // Parameter defaults
             );
            routes.MapRoute(                                            // Route name
                "BooksAddition",                                              // Route name
                "books/addition",                           // URL with parameters
                new { controller = "Home", action = "bookAddition" }  // Parameter defaults
            );
           
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
                routes.MapRoute(                                            // Route name
                 "BooksList",                                              // Route name
                 "books/list",                           // URL with parameters
                 new { controller = "Home", action = "bookList" }  // Parameter defaults
             );
                routes.MapRoute(                                            // Route name
                  "BooksSearch",                                              // Route name
                  "books/search",                           // URL with parameters
                  new { controller = "Home", action = "bookSearch" }  // Parameter defaults
              );
              
            routes.MapRoute(                                            // Route name
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );

        }
    }
}

