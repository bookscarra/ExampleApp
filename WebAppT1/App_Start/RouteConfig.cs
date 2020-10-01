using Microsoft.AspNet.FriendlyUrls;
using Serilog;
using System;
using System.Configuration;
using System.Web.Routing;

namespace WebAppT1
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings
            {
                AutoRedirectMode = RedirectMode.Permanent
            };
            routes.EnableFriendlyUrls(settings);

            RegisterLogger();
        }

        private static void RegisterLogger()
        {
            var logPath = ConfigurationManager.AppSettings["LogPath"];

            Log.Logger = new LoggerConfiguration() 
                                .Enrich.WithProperty("Version", "1.0.0") 
                                .MinimumLevel.Debug() 
                                .WriteTo.File(System.IO.Path.Combine(logPath, "example_log_.txt"),
                                                rollingInterval: RollingInterval.Day,
                                                flushToDiskInterval: TimeSpan.FromMinutes(5)) 
                                 .CreateLogger();
            Log.Information("Application Started");
        }
    }
}
