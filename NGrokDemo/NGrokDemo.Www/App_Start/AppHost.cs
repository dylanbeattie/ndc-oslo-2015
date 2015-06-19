using System.Configuration;
using System.Web.Mvc;
using NGrokDemo.Www.Services;
using ServiceStack;
using ServiceStack.Auth;
using ServiceStack.Configuration;
using ServiceStack.Data;
using ServiceStack.Mvc;
using ServiceStack.OrmLite;

[assembly: WebActivator.PreApplicationStartMethod(typeof(NGrokDemo.Www.App_Start.AppHost), "Start")]

//IMPORTANT: Add the line below to RouteConfig.RegisterRoutes(RouteCollection) in the Global.asax:
//routes.IgnoreRoute("api/{*pathInfo}"); 
//More info on how to integrate with MVC: https://github.com/ServiceStack/ServiceStack/wiki/Mvc-integration

/**
 * Entire ServiceStack Starter Template configured with a 'Hello' Web Service and a 'Todo' Rest Service.
 *
 * Auto-Generated Metadata API page at: /metadata
 * See other complete web service examples at: https://github.com/ServiceStack/ServiceStack.Examples
 */

namespace NGrokDemo.Www.App_Start {
    //A customizeable typed UserSession that can be extended with your own properties
    //To access ServiceStack's Session, Cache, etc from MVC Controllers inherit from ControllerBase<CustomUserSession>
    public class CustomUserSession : AuthUserSession {
        public string CustomProperty { get; set; }
    }

    public class AppHost
        : AppHostBase {
        public AppHost() //Tell ServiceStack the name and where to find your web services
            : base("StarterTemplate ASP.NET Host", typeof(HelloService).Assembly) { }

        public override void Configure(Funq.Container container) {
            //Set JSON web services to return idiomatic JSON camelCase properties
            ServiceStack.Text.JsConfig.EmitCamelCaseNames = true;

            //Configure User Defined REST Paths
            Routes
              .Add<Hello>("/hello")
              .Add<Hello>("/hello/{Name*}");

            //Uncomment to change the default ServiceStack configuration
            //SetConfig(new HostConfig
            //{
            //});

            //Enable Authentication
            //ConfigureAuth(container);

            //Register all your dependencies
            // container.Register(new TodoRepository());

            //Set MVC to use the same Funq IOC as ServiceStack
            ControllerBuilder.Current.SetControllerFactory(new FunqControllerFactory(container));
        }

        public static void Start() {
            new AppHost().Init();
        }
    }
}
