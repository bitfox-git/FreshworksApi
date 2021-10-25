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
            // get config file
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsettings.json");
            IConfiguration configuration = configurationBuilder.Build();

            // Create client
            FreshworkConfig options = new(configuration);
            Client = new CRMClientBuilder(options).Build();
        }
    }
}
