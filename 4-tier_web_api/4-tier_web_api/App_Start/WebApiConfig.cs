using BLL.MapperConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace _4_tier_web_api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            EnableCorsAttribute cors = new EnableCorsAttribute("*","*","*");
            config.EnableCors(cors);
            AutoMapper.Mapper.Initialize(con => con.AddProfile<AutoMapperSettings>());
            //config.EnableCors();
        }
    }
}
