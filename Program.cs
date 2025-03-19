using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using my_dotnet_backend_service; // Add this using directive to reference the Startup class

namespace my_dotnet_backend_service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}