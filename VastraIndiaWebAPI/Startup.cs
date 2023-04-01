//using Microsoft.Extensions.DependencyInjection;
//using Owin;

//namespace VastraIndiaWebAPI
//{
//    public partial class Startup
//    {
//        public void ConfigureServices(IServiceCollection services)
//        {

//            // Allow CORS
//            services.AddCors(options =>
//            {
//                options.AddPolicy("CorsPolicy", builder =>
//                {
//                    builder.AllowAnyOrigin()
//                        .AllowAnyMethod()
//                        .AllowAnyHeader()
//                        .AllowCredentials();
//                });
//            });

//            // Add Web API services
//            services.AddMvc();
//        }


//    public void Configure(IAppBuilder app)
//    {
//        app.Use("CorsPolicy");
//        //app.UseMvc();
//    }
// }
//}

////using Owin;
////using System.Web.Http;

////namespace VastraIndiaWebAPI
////{
////    public partial class Startup
////    {
////        //public void Configuration(IAppBuilder app)
////        //{
////        //    var config = new HttpConfiguration();
////        //    config.EnableCors(new EnableCorsAttribute("http://localhost:4200", "*", "*"));

////        //    // Other Web API configuration code
////        //    app.Use(config);
////        //}

////        public void Configuration(IAppBuilder appBuilder)
////        {
////            HttpConfiguration config = new HttpConfiguration();

////            // Configure Web API routes
////            config.MapHttpAttributeRoutes();
////            config.Routes.MapHttpRoute(
////                name: "DefaultApi",
////                routeTemplate: "api/{controller}/{id}",
////                defaults: new { id = RouteParameter.Optional }
////            );

////            // Use the Web API middleware
////            //appBuilder.UseWebApi(config);
////        }
////    }
////}

//////using Owin;

////namespace VastraIndiaWebAPI
////{
////    public partial class Startup
////    {
////        public void Configuration(IAppBuilder app)
////        {
////            ConfigureAuth(app);

////        }
////    }
////}

//////        public void ConfigureServices(IServiceCollection services)
//////        {
//////            //services.AddDbContext<CoreDbContext>(op => op.UseSqlServer(Configuration.GetConnectionString("Database"))); //Add       
//////            //services.AddControllers();

//////            services.AddCors(options =>
//////            {
//////                options.AddPolicy("EnableCORS", builder =>
//////                {
//////                    builder.AllowAnyOrigin()
//////                    .AllowAnyHeader()
//////                    .AllowAnyMethod();
//////                });
//////            });
//////        }


//////        }
//////}

using Owin;
using System.Web.Http;
namespace VastraIndiaWebAPI
{
    public partial class Startup
    {
        //public void Configuration(IAppBuilder app)
        //{
        //    //// Enable CORS for all origins, headers, and methods
        //    //var cors = new EnableCorsAttribute("*", "*", "*");
        //    //GlobalConfiguration.Configuration.EnableCors(cors);

        //    //// Configure JSON serialization settings
        //    //var jsonSettings = new JsonSerializerSettings
        //    //{
        //    //    ContractResolver = new CamelCasePropertyNamesContractResolver(),
        //    //    NullValueHandling = NullValueHandling.Ignore,
        //    //    Formatting = Formatting.None
        //    //};
        //    //GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings = jsonSettings;

        //    //// Configure Web API routes
        //    //GlobalConfiguration.Configuration.MapHttpAttributeRoutes();
        //    //GlobalConfiguration.Configuration.Routes.MapHttpRoute(
        //    //    name: "DefaultApi",
        //    //    routeTemplate: "api/{controller}/{id}",
        //    //    defaults: new { id = RouteParameter.Optional }
        //    //);

        //}
        public void Configuration(IAppBuilder app)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);

           // app.Use(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            //app.UseWebApi(config);
        }
    }
}


