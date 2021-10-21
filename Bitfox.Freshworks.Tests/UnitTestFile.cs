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
    public class UnitTestFile
    {
        private readonly ICRMClient _client;

        public UnitTestFile(ClientFixture clientFixture)
        {
            _client = clientFixture.Client;
        }

        [Fact]
        public async Task InsertFileOnSuccess()
        {
            Network.GoPost();





        }







    }
}
