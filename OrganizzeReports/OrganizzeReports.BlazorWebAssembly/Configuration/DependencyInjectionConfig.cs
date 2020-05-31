using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrganizzeReports.BlazorWebAssembly .Integration;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OrganizzeReports.BlazorWebAssembly.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient("Refit",
                options =>
                {
                    options.BaseAddress = new Uri(configuration["OrganizzeApi:Url"]);
                    options.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                                                                  Convert.ToBase64String(
                                                                    Encoding.ASCII.GetBytes(
                                                                       $"{configuration["OrganizzeApi:Usuario"]}:{configuration["OrganizzeApi:Token"]}")));

                    options.DefaultRequestHeaders.Add("User-Agent", "OrganizzeReports");
                })
                .AddTypedClient(RestService.For<IOrganizzeApi>);

            return services;
        }
    }
}
