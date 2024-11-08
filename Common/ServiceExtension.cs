using Common.HttpHelpers;
using Common.Settings;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Common
{
    public static class ServiceExtension
    {
        public static void AddCommonLayer(this IServiceCollection services)
        {
            services.AddScoped(typeof(UtilitariesResponse<>));
            services.AddScoped<IConfigurationLib, ConfigurationLib>();
        }
    }
}
