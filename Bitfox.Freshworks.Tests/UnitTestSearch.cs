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
    public class UnitTestSearch
    {
        private readonly ICRMClient _client;

        public UnitTestSearch(ClientFixture clientFixture)
        {
            _client = clientFixture.Client;
        }

        [Fact]
        public async Task SearchOnSuccess()
        {
            var result = await _client.Query()
                .Include("contact")
                .Include("user")
                .Include("sales_account")
                .Include("deal")
                .SearchOnQuery("sample");

            Assert.NotNull(result.Content);
            Assert.Null(result.Error);
        }

        [Fact]
        public async Task FilteredSearchOnSuccess()
        {

            //_client.Query().

            SearchFilter filter = new();
            var result = await _client.SearchOnFilter<Contact>(filter);

            Assert.NotNull(result.Content);
            Assert.Null(result.Error);
        }

        [Fact]
        public async Task LookupSearchOnSuccess()
        {
            var result = await _client.SearchOnLookup("janesampleton@gmail.com", "email", "contact");

            Assert.NotNull(result.Content);
            Assert.Null(result.Error);
        }




    }
}
