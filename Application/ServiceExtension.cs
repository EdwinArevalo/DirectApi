using Application.Services.Core.Implements;
using Application.Services.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ServiceExtension
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IUtilService, UtilService>();
            services.AddScoped<IAuthGMService, AuthGMService>();
            services.AddScoped<IBalanceGMService, BalanceGMService>();
        }
    }
}
