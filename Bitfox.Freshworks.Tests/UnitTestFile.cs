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
            Account account = await CreateAccount();
            File file = new()
            {
                FilePath = "C:\\Users\\n.tuytel\\OneDrive - Lucrasoft ICT Groep\\Afbeeldingen\\IMG-20210819-WA0004.jpg",
                NewFileName = "IMG-20210819-WA0004.jpg",
                IsShared = true,
                TargetableID = account.ID,
                TargetableType = "SalesAccount"
            };

            var result = await _client.InsertForm(file);
            Assert.NotNull(result.Value);
            Assert.Null(result.Error);

            await _client.Delete(account);
        }

        [Fact]
        public async Task CreateALinkOnSuccess()
        {
            Account account = await CreateAccount();
            FileLink file = new()
            {
                URL = "https://s3.amazonaws.com/cdn.freshsales.io/629493/documents/17000009586/original/IMG-20210819-WA0004.jpg?AWSAccessKeyId=AKIAXGJAZIKAU2T5F46N&Expires=1634896487&Signature=QWMSn92J9Ix%2B6IizW5KvGBvJQAw%3D",
                IsShared = false,
                TargetableID = account.ID,
                TargetableType = "SalesAccount",
                Name = "some random name"
            };

            var result = await _client.Insert(file);
            Assert.NotNull(result.Value);
            Assert.Null(result.Error);

            await _client.Delete(account);
        }

        [Fact]
        public async Task ListAllFilesAndLinksOnSuccess()
        {
            Account account = await CreateAccount();

            var result = await _client.GetAllFileAndLinks(account);
            //var result = await _client.GetAllFileAndLinks<Sale>(17001420209);

            Assert.NotNull(result.Value);
            Assert.Null(result.Error);

            await _client.Delete(account);
        }

        private async Task<Account> CreateAccount()
        {
            // get owner id
            var owners = await _client.Selector.GetOwners();
            var owner = (owners.Value as Selector).Users[0];

            Account acc = new()
            {
                Name = $"TEST INSERT Name:({DateTime.Now})",
                OwnerID = owner.ID
            };

            // execute creation
            var output = await _client.Insert(acc);
            return (output.Value as Account).Account;
        }

    }
}
