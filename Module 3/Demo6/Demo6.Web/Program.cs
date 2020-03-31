using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Demo6.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Serilog basic configuration
            Log.Logger = new LoggerConfiguration()
                                .MinimumLevel.Information()
                                .WriteTo.Console()
                                .WriteTo.File("_logs\\log_.txt", rollingInterval: RollingInterval.Day)
                                .CreateLogger();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                       .ConfigureWebHostDefaults(webBuilder =>
                       {
                           webBuilder.UseStartup<Startup>();
                       })
                       .UseSerilog(); // DO NOT forget this line
        }
    }
}
