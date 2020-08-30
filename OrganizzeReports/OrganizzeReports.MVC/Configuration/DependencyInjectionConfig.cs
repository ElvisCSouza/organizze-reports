using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrganizzeReports.MVC.Core.Notificacoes;
using OrganizzeReports.MVC.Integration;
using OrganizzeReports.MVC.Services;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OrganizzeReports.MVC.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<OrganizzeAuthHttpClientDelegatingHandler>();

            services.AddHttpClient("Refit",
                options =>
                {
                    options.BaseAddress = new Uri(configuration["OrganizzeApi:Url"]);
                    options.DefaultRequestHeaders.Add("User-Agent", "OrganizzeReports");
                })
                .AddHttpMessageHandler<OrganizzeAuthHttpClientDelegatingHandler>()
                .AddTypedClient(RestService.For<IOrganizzeApi>);

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAutenticacaoService, AutenticacaoService>();
            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IUser, OrganizzeUser>();

            return services;
        }
    }
}
