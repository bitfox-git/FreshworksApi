using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Bitfox.Freshworks.Tests
{
    [Collection("Client Collection")]
    public class UnitTestDeal
    {
        private readonly ITestOutputHelper _console;
        private readonly ICRMClient _client;
        private readonly UnitTestSelectors _selectors;

        public UnitTestDeal(ITestOutputHelper console, ClientFixture clientFixture)
        {
            _console = console;
            _client = clientFixture.Client;
            _selectors = new UnitTestSelectors(console, clientFixture);
        }

        [Fact]
        public async Task GetDealFiltersOnSuccess()
        {
            _ = await GetDealFilters();
        }

        [Fact]
        public async Task InsertDealOnSuccess()
        {
            Deal deal = await CreateDeal();

            _ = await RemoveDeal(deal.Deal);
        }

        [Fact]
        public async Task GetDealByIDOnSuccess()
        {
            Deal deal = await GetDealByID();

            _ = await RemoveDeal(deal.Deal);
        }

        [Fact]
        public async Task GetDealByIDAndIncludesOnSuccess()
        {
            Deal deal = await GetDealByIDAndSelectors();

            _ = await RemoveDeal(deal.Deal);
        }

        [Fact]
        public async Task GetAllDealsByIDOnSuccess()
        {
            _ = await GetAllDealsByID();
        }

        [Fact]
        public async Task UpdateDealOnSuccess()
        {
            Deal deal = await CreateDeal();

            deal = await UpdateDeal(deal.Deal);

            _ = await RemoveDeal(deal.Deal);
        }

        [Fact]
        public async Task CloneDealOnSuccess()
        {
            var deal = await CreateDeal();
            var clonedDeal = await CloneDeal(deal.Deal);

            _ = await RemoveDeal(deal.Deal);
            _ = await RemoveDeal(clonedDeal.Deal);

        }

        [Fact]
        public async Task DeleteDealOnSuccess()
        {
            Deal deal = await CreateDeal();

            _ = await RemoveDeal(deal.Deal);
        }

        [Fact]
        public async Task ForgetDealOnSuccess()
        {
            Deal deal = await CreateDeal();

            _ = await ForgetDeal(deal.Deal);
        }

        [Fact]
        public async Task DeleteBulkDealOnSuccess()
        {
            Deal deal = await CreateDeal();

            _ = await DeleteDealBulk(deal.Deal);
        }

        [Fact]
        public async Task AllFieldsDealOnSuccess()
        {
            _ = await AllDealFields();
        }

        public async Task<Deal> GetDealFilters()
        {
            var result = await _client.FetchAll<Deal>();
            //var result = await _client.Deal.FetchAll<Deal>();

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            
            return result.Value as Deal;

        }

        public async Task<Deal> CreateDeal()
        {
            // get owner id
            var owners = await _selectors.GetOwners();
            var owner = owners[0];

            Deal deal = new()
            {
                Name = $"TEST INSERT Name:({GetCurrentTime()})",
                OwnerID = owner.ID,
                Amount = "12"
            };

            // execute creation
            var result = await _client.Insert(deal);


            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            
            return result.Value as Deal;
        }

        public async Task<bool> RemoveDeal(Deal deal)
        {
            // execute
            var result = await _client.Delete(deal);
            //var result = await _client.Deal.Delete(deal);
            //var result = await _client.Delete<Deal>(deal.ID);
            //var result = await _client.Deal.Delete<Deal>(deal.ID);

            Assert.True((bool)result.Value);
            return (bool)result.Value;
        }

        public async Task<Deal> GetDealByID()
        {
            var deal = await CreateDeal();

            // exucute get account
            var result = await _client.Query.GetByID(deal.Deal);
            //var result = await _client.Query.GetByID<Deal>(deal.ID);
            //var result = await _client.Deal.Query.GetByID(deal);
            //var result = await _client.Deal.Query.GetByID<Deal>(deal.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            
            return result.Value as Deal;
        }

        public async Task<Deal> GetDealByIDAndSelectors()
        {
            // create account
            var deal = await CreateDeal();

            // exucute get account
            var result = await _client.Query
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
                .GetByID(deal.Deal);
            //var result = await _client.Query().Include("owner").GetByID<Deal>(deal.Item.ID);
            //var result = await _client.Deal.Query().Include("owner").GetByID(deal.Item);
            //var result = await _client.Deal.Query().Include("owner").GetByID<Deal>(deal.Item.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            return result.Value as Deal;
        }

        public async Task<Deal> GetAllDealsByID()
        {
            // get account
            var filters = await GetDealFilters();
            var content = filters.Filters[0];
            Deal deal = new() { ID = content.ID };

            // execute
            var result = await _client.Query.GetAllByID(deal);
            //var result = await _client.Query.GetAllByID<Deal>(deal.ID);
            //var result = await _client.Deal.Query.GetAllByID(deal);
            //var result = await _client.Deal.Query.GetAllByID<Deal>(deal.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            
            return result.Value as Deal;
        }

        public async Task<Deal> UpdateDeal(Deal deal)
        {
            deal.Name = $"TEST Random Name:({GetCurrentTime()})";

            // execute
            var result = await _client.Update(deal);
            //var result = await _client.Deal.Update(deal);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            
            return result.Value as Deal;
        }

        public async Task<Deal> CloneDeal(Deal deal)
        {
            deal.Name = $"TEST Clone Name:({GetCurrentTime()})";

            // Commands
            var result = await _client.Clone(deal);
            //var result = await _client.Deal.Clone(deal);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            
            return result.Value as Deal;
        }

        public async Task<bool> ForgetDeal(Deal deal)
        {
            // execute
            var result = await _client.Forget(deal);
            //var result = await _client.Deal.Forget(deal);
            //var result = await _client.Forget<Deal>(deal.ID);
            //var result = await _client.Deal.Forget<Deal>(deal.ID);

            Assert.True((bool)result.Value);
            return (bool)result.Value;
        }

        public async Task<Deal> DeleteDealBulk(Deal deal)
        {
            Deal bulk = new()
            {
                SelectedIDs = new List<long> { (long)deal.ID },
                DeleteAssociatedContactDeals = true
            };

            // Commands
            var result = await _client.DeleteBulk(bulk);
            //var result = await _client.Deal.DeleteBulk(bulk);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            
            return result.Value as Deal;
        }

        public async Task<Deal> AllDealFields()
        {
            // Commands
            var result = await _client.Query.GetAllFields<Deal>();
            //var result = await _client.Deal.Query.GetAllFields<Deal>();

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            
            return result.Value as Deal;
        }

        private static string GetCurrentTime()
        {
            return DateTime.Now.ToString();
        }
    }
}





