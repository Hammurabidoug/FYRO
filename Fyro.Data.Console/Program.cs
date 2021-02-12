using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Fyro.Data.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((hostContext, services) =>
        {
            services.AddHostedService<Worker>();
            services.AddDbContext<FyroDbContext>(
                options =>
                    options.UseSqlServer(
                        hostContext.Configuration.GetConnectionString("DefaultConnection"),
                        x => x.MigrationsAssembly("Fyro.Data.SqlServer")));
        });
    }
}
