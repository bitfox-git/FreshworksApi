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
        public async Task InsertAccountOnSuccess()
        {
            Account account = await CreateAccount();

            _ = await RemoveAccount(account);
        }

        [Fact]
        public async Task GetAccountFiltersOnSuccess()
        {
            _ = await GetAccountFilters();
        }

        [Fact]
        public async Task GetAccountByIDOnSuccess()
        {
            Account account = await GetAccountByID();

            _ = await RemoveAccount(account);
        }

        [Fact]
        public async Task GetAccountByIDAndIncludesOnSuccess()
        {
            Account account = await GetAccountByIDAndSelectors();

            _ = await RemoveAccount(account.Item);
        }

        [Fact]
        public async Task GetAllAccountsByIDOnSuccess()
        {
            _ = await GetAllAccountsByID();
        }

        [Fact]
        public async Task UpdateAccountOnSuccess()
        {
            Account account = await CreateAccount();

            account = await UpdateAccount(account);

            _ = await RemoveAccount(account);
        }

        [Fact]
        public async Task CloneAccountOnSuccess()
        {
            var account = await CreateAccount();
            var clonedAccount = await CloneAccount(account);

            _ = await RemoveAccount(account);
            _ = await RemoveAccount(clonedAccount);

        }

        [Fact]
        public async Task DeleteAccountOnSuccess()
        {
            // get account
            Account account = await CreateAccount();

            _ = await RemoveAccount(account);
        }

        [Fact]
        public async Task ForgetAccountOnSuccess()
        {
            Account account = await CreateAccount();

            _ = await ForgetAccount(account);
        }

        [Fact]
        public async Task DeleteBulkAccountOnSuccess()
        {
            Account account = await CreateAccount();

            _ = await DeleteAccountBulk(account);
        }

        [Fact]
        public async Task AllFieldsAccountOnSuccess()
        {
            _ = await AllAccountFields();
        }

        /// <summary>
        /// 
        /// </summary>

        private async Task<Account> GetAccountFilters()
        {
            var result = await _client.FetchAll<Account>();
            //var result = await _client.Account.FetchAll<Account>();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;

        }

        private async Task<Account> CreateAccount()
        {
            // get owner id
            var owners = await _selectors.GetOwners();
            var owner = (owners as List<User>)[0];

            Account account = new()
            {
                Name = $"TEST INSERT Name:({GetCurrentTime()})",
                OwnerID = owner.ID
            };

            // execute creation
            var result = await _client.Insert(account);


            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content as Account;
        }

        private async Task<bool> RemoveAccount(Account account)
        {
            // execute
            var result = await _client.Delete(account);
            //var result = await _client.Account.Delete(account);
            //var result = await _client.Delete<Account>(account.ID);
            //var result = await _client.Account.Delete<Account>(account.ID);

            Assert.True((bool)result.Content);
            return (bool)result.Content;
        }

        private async Task<Account> GetAccountByID()
        {
            var account = await CreateAccount();

            // exucute get account
            var result = await _client.Query().GetByID(account);
            //var result = await _client.Query().GetByID<Account>(account.ID);
            //var result = await _client.Account.Query().GetByID(account);
            //var result = await _client.Account.Query().GetByID<Account>(account.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        private async Task<Account> GetAccountByIDAndSelectors()
        {
            // create account
            var account = await CreateAccount();

            // exucute get account
            var result = await _client.Query()
                .Include("owner")
                .Include("creater")
                .Include("updater")
                .Include("territory")
                .Include("business_type")
                .Include("tasks")
                .Include("appointments")
                .Include("contacts")
                .Include("deals")
                .Include("industry_type")
                .Include("child_sales_accounts")
                .GetByID(account);
            //var result = await _client.Query().Include("owner").GetByID<Account>(account.ID);
            //var result = await _client.Account.Query().Include("owner").GetByID(account);
            //var result = await _client.Account.Query().Include("owner").GetByID<Account>(account.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.NotNull(result.Includes);
            return GetResponse(result) as Account;
        }

        private async Task<Account> GetAllAccountsByID()
        {
            // get account
            var filters = await GetAccountFilters();
            var content = filters.Filters[0];
            Account account = new(){ ID = content.ID };

            // execute
            var result = await _client.Query().GetAllByID(account);
            //var result = await _client.Query().GetAllByID<Account>(content.ID);
            //var result = await _client.Account.Query().GetAllByID(account);
            //var result = await _client.Account.Query().GetAllByID<Account>(content.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        private async Task<Account> UpdateAccount(Account account)
        {
            account.Name = $"TEST Random Name:({GetCurrentTime()})";

            // execute
            var result = await _client.Update(account);
            //var result = await _client.Account.Update(account);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        private async Task<Account> CloneAccount(Account account)
        {
            account.Name = $"TEST Clone Name:({GetCurrentTime()})";

            // Commands
            var result = await _client.Clone(account);
            //var result = await _client.Account.Clone(account);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        private async Task<bool> ForgetAccount(Account account)
        {
            // execute
            var result = await _client.Forget(account);
            //var result = await _client.Account.Forget(account);
            //var result = await _client.Forget<Account>(account.ID);
            //var result = await _client.Account.Forget<Account>(account.ID);

            Assert.True((bool)result.Content);
            return (bool)result.Content;
        }

        private async Task<Account> DeleteAccountBulk(Account account)
        {
            Account bulk = new()
            {
                SelectedIDs = new List<long> { (long)account.ID },
                DeleteAssociatedContactDeals = true
            };

            // Commands
            var result = await _client.DeleteBulk(bulk);
            //var result = await _client.Account.DeleteBulk(bulk);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        public async Task<Account> AllAccountFields()
        {
            // Commands
            var result = await _client.Query().GetAllFields<Account>();
            //var result = await _client.Account.Query().GetAllFields<Account>();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Account;
        }

        /// <summary>
        /// 
        /// </summary>

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
