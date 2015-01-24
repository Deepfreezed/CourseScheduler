using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CourseScheduler.Website
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
			//JSON formatting with camel case for Java Script
			var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
			jsonFormatter.SerializerSettings.ContractResolver
				= new CamelCasePropertyNamesContractResolver();

			// Setting this to prevent self referencing loop issue...
			GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling 
				= PreserveReferencesHandling.Objects;

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "ProgramRoute",
				routeTemplate: "api/program/{id}/courses",
				defaults: new { controller = "program", id = RouteParameter.Optional }
			);	

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );			
        }
    }
}
