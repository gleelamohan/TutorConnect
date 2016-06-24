
using System.Web.Http;
using SimpleInjector.Integration.WebApi;
using SimpleInjector;
using TutorConnectBusinessContracts;
using TutorConnectDataContracts;

namespace TutorConnect
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
          // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
