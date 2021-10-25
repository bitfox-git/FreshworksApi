using Bitfox.Freshworks.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    /// <summary>
    /// Extension method for configurations.
    /// </summary>
    public static class ServicesConfiguration
    {
        public static void AddFreshworks(this IServiceCollection services)
        {
            // get config file
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsettings.json");
            IConfiguration configuration = configurationBuilder.Build();

            ServicesConfiguration.AddFreshworks(services, configuration);
        }

        public static void AddFreshworks(this IServiceCollection services, IConfiguration configuration)
        {
            FreshworkConfiguration options = new(configuration);
            ICRMClient client = new CRMClientBuilder(options).Build();

            services.AddSingleton(client);
        }
    }
}
