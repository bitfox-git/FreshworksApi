using Bitfox.Freshworks.Models;
using Microsoft.Extensions.Configuration;
using System;
using Xunit;

namespace Bitfox.Freshworks.Tests
{
    [CollectionDefinition("Client Collection")]
    public class ClientCollection : ICollectionFixture<ClientFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }

    public class ClientFixture
    {
        public ICRMClient Client { get; private set; }

        public ClientFixture()
        {
            Client = GetClient();
        }

        private static ICRMClient GetClient()
        {
            FreshworkOptions options = GetOptions();
            return new CRMClientBuilder()
                                    .SetSubdomain(options.Domain)
                                    .SetApiKey(options.ApiKey)
                                    .Build();
        }

        private static FreshworkOptions GetOptions()
        {
            // get config file
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();

            configurationBuilder.AddJsonFile("appsettings.json");
            IConfiguration configuration = configurationBuilder.Build();

            var options = new FreshworkOptions();
            string optionName = FreshworkOptions.Position;
            configuration.GetSection(optionName).Bind(options);

            return options;
        }
    }
}
