using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Bitfox.Freshworks.Tests
{
    [Collection("Client Collection")]
    public class UnitTestPhone
    {
        private readonly ICRMClient _client;

        public UnitTestPhone(ClientFixture clientFixture)
        {
            _client = clientFixture.Client;
        }

        [Fact]
        public async Task InsertCallLogOnSuccess()
        {
            Phone phone = new() { };
            var result = await _client.Insert(phone);

            Assert.NotNull(result.Content);
            Assert.Null(result.Error);
        }






    }
}
