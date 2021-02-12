using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using Radzen;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Fyro.Web.Blazor.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddMudServices();

            var configuration = builder.Configuration;

            builder.Services.AddOptions();

            builder.Services.Configure<MappingOptions>(options =>
            {
                configuration.GetSection("Mapping").Bind(options);
            } );

            //builder.Services.Configure<MappingOptions>(builder.Configuration.GetSection("Mapping"));

            await builder.Build().RunAsync();
        }
    }
}
