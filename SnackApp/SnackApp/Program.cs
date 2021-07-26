using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using SnackApp.Extensao;

namespace SnackApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // We created the CreateAdminRole extension method
            CreateHostBuilder(args)
                .Build()
                .CreateAdminRole()
                .Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
        }
    }
}