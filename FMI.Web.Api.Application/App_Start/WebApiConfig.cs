using Castle.Windsor;
using System.Web.Http;
using System.Web.Http.Dispatcher; 

namespace FMI.Web.Api.Application
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config, IWindsorContainer container)
        { 
            MapRoutes(config);

            RegisterControllerActivator(container);
        }

        private static void MapRoutes(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );

            config.EnableSystemDiagnosticsTracing();
        }

        private static void RegisterControllerActivator(IWindsorContainer container)
        {
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), new WindsorCompositionRoot(container));
        }
    }
}
