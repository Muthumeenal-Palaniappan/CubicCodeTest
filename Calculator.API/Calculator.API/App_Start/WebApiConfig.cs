using Calcuclator.Business;
using Calcuclator.Business.Interfaces;
using Calculator.API.Helper;
using Calculator.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;

namespace Calculator.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<ISimpleCalculatorService, SimpleCalculatorService>();
            container.RegisterType<IDiagnosticRepository, DiagnosticRepository>();
            config.DependencyResolver = new UnityResolver(container);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
        
    }
}
