using System.Web.Http;
using System.Web.Http.Cors;

namespace NumbersToWordsConverter.Services
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // CORS Attributes
            var corsAttribute = new EnableCorsAttribute("*", "*", "*");
            
            // Enable CORS
            config.EnableCors(corsAttribute);

            // JSON Return Type
            config.Formatters.JsonFormatter.SupportedMediaTypes
                .Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));

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
