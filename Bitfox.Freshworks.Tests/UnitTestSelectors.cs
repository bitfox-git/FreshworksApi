using Microsoft.Extensions.Configuration;
using Bitfox.Freshworks.Models;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using System.Threading;
using System.Collections.Generic;
using Bitfox.Freshworks.Endpoints.Selector;

namespace Bitfox.Freshworks.Tests
{

    [Collection("Client Collection")]
    public class UnitTestSelectors
    {
        private readonly ITestOutputHelper _console;
        private readonly ICRMClient _client;

        public UnitTestSelectors(ITestOutputHelper console, ClientFixture clientFixture)
        {
            _console = console;
            _client = clientFixture.Client;
        }

        [Fact]
        public async Task<List<User>> GetOwnersOnSuccess()
        {
            var result = await _client.GetOwners();
            //var result = await _client.Selector.GetOwners();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);

            // Result
            if (result.Content != null)
            {
                List<User> users = (result.Content as List<User>);
                _console.WriteLine($"The result content type: {result.Content.GetType()}");
                return users;
            }
            else
            {
                _console.WriteLine($"The result error message: {result.Error.Message}");
                return null;
            }
        }






    }
}
