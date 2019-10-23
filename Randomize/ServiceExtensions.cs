using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IRandomzer, Randomzer>();

            return services;
        }

        public static IServiceCollection AddRandomiserOptions(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddOptions();//Registers IOptions<> to OptionManager<>
            services.Configure<RandomizeOptions>(configuration.GetSection("RandomizeOptions"));
            services.Configure<MyNewOptions>(configuration.GetSection("MyNewOptions"));


            return services;
        }
    }
}
