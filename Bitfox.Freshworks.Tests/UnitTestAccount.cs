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
    public class UnitTestAccount
    {
        private readonly ITestOutputHelper _console;
        private readonly ICRMClient _client;
        private readonly UnitTestSelectors _selectors;

        public UnitTestAccount(ITestOutputHelper console, ClientFixture clientFixture)
        {
            _console = console;
            _client = clientFixture.Client;
            _selectors = new UnitTestSelectors(console, clientFixture);
        }

        [Fact]
        public async Task<Account> InsertAccountOnSuccess()
        {
            // get owner id
            var owners = await _selectors.GetOwnersOnSuccess();
            var owner = owners[0];

            Account account = new()
            {
                Name = $"TEST Random Name:({GetCurrentTime()})",
                OwnerID = owner.ID
            };

            // Commands
            var result = await _client.Insert(account);
            //var result = await client.Account.Insert(account);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        [Fact]
        public async Task<Account> GetAccountFiltersOnSuccess()
        {
            // Commands
            var result = await _client.GetFilters<Account>();
            //var result = await _client.Account.GetFilters<Account>();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        [Fact]
        public async Task<Account> GetByIDAccountOnSuccess()
        {
            // get account
            var account = await InsertAccountOnSuccess();

            // Commands
            var result = await _client.Query().GetByID(account);
            //var result = await _client.Query().GetByID<Account>(account.ID);
            //var result = await _client.Account.Query().GetByID(account);
            //var result = await _client.Account.Query().GetByID<Account>(account.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        [Fact]
        public async Task<Account> GetByIDAndIncludesAccountOnSuccess()
        {
            // get account
            var account = await InsertAccountOnSuccess();

            // Commands
            var result = await _client.Query().Include("owner").GetByID(account);
            //var result = await _client.Query().Include("owner").GetByID<Account>(account.ID);
            //var result = await _client.Account.Query().Include("owner").GetByID(account);
            //var result = await _client.Account.Query().Include("owner").GetByID<Account>(account.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.NotNull(result.Includes);

            return GetResponse(result) as Account;
        }

        [Fact]
        public async Task<Account> GetAllByIDAccountOnSuccess()
        {
            // get account
            var filters = await GetAccountFiltersOnSuccess();
            var content = filters.Filters[0];
            Account account = new()
            {
                ID = content.ID
            };

            // Commands
            var result = await _client.Query().GetAllByID(account);
            //var result = await _client.Query().GetAllByID<Account>(content.ID);
            //var result = await _client.Account.Query().GetAllByID(account);
            //var result = await _client.Account.Query().GetAllByID<Account>(content.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        [Fact]
        public async Task<Account> UpdateAccountOnSuccess()
        {
            // get account
            var account = await InsertAccountOnSuccess();
            account.Name = $"TEST Random Name:({GetCurrentTime()})";

            // Commands
            var result = await _client.Update(account);
            //var result = await _client.Account.Update(account);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        [Fact]
        public async Task<Account> CloneAccountOnSuccess()
        {
            // get account
            var account = await InsertAccountOnSuccess();
            account.Name = $"TEST Clone Name:({GetCurrentTime()})";

            // Commands
            var result = await _client.Clone(account);
            //var result = await _client.Account.Clone(account);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        [Fact]
        public async Task<Account> DeleteAccountOnSuccess()
        {
            // get account
            var account = await InsertAccountOnSuccess();

            // Commands
            var result = await _client.Delete(account);
            //var result = await _client.Account.Delete(account);
            //var result = await _client.Delete<Account>(account.ID);
            //var result = await _client.Account.Delete<Account>(account.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        [Fact]
        public async Task<Account> ForgetAccountOnSuccess()
        {
            // get account
            var account = await InsertAccountOnSuccess();

            // Commands
            var result = await _client.Forget(account);
            //var result = await _client.Account.Forget(account);
            //var result = await _client.Forget<Account>(account.ID);
            //var result = await _client.Account.Forget<Account>(account.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        [Fact]
        public async Task<Account> DeleteBulkAccountOnSuccess()
        {
            // get account
            var account = await InsertAccountOnSuccess();
            Account bulk = new()
            {
                SelectedIDs = new List<long> { (long)account.ID },
                DeleteAssociatedContactsDeals = true
            };

            // Commands
            var result = await _client.DeleteBulk(bulk);
            //var result = await _client.Account.DeleteBulk(bulk);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        [Fact]
        public async Task<Account> AllFieldsAccountOnSuccess()
        {
            // Commands
            var result = await _client.Query().GetAllFields<Account>();
            //var result = await _client.Account.Query().GetAllFields<Account>();
            
            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        private object GetResponse<TEntity>(Result<TEntity> result)
        {
            if (result.Content != null)
            {
                _console.WriteLine($"The result content type: {result.Content.GetType()}");
                return result.Content;
            }
            else
            {
                _console.WriteLine($"The result error message: {result.Error.Message}");
                return null;
            }
        }

        private static string GetCurrentTime()
        {
            return DateTime.Now.ToString();
        }
    }
}
