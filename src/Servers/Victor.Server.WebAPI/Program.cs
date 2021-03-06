using System.IO;
using System.Net;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

using Microsoft.Extensions.Logging;

using Serilog;
using Serilog.Events;

namespace Victor.Server.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Debug)
            .Enrich.WithMachineName()
            .Enrich.WithThreadId()
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .WriteTo.File(Path.Combine(Api.AssemblyDirectory.FullName, "Victor.log"))
            .CreateLogger();
            Api.SetLogger(new SerilogLogger(Log.Logger));

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddSerilog(Log.Logger);
                })
                //.UseKestrel(options => options.Listen(IPAddress.Any, 8080))
                .UseStartup<Startup>();
    }
}
