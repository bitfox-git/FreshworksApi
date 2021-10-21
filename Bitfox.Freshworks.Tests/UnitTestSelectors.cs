using Bitfox.Freshworks.Endpoints.Selector;
using Bitfox.Freshworks.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

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
        public async Task GetSalesActivityTypesOnSuccess()
        {
            _ = await GetSalesActivityTypes();
        }

        [Fact]
        public async Task GetSalesActivityEntityTypesOnSuccess()
        {
            _ = await GetSalesActivityEntityTypes();
        }

        [Fact]
        public async Task GetSalesActivityOutcomesOnSuccess()
        {
            _ = await GetSalesActivityOutcomes();
        }

        [Fact]
        public async Task GetSalesActivityOutcomesByIDOnSuccess()
        {
            Assert.True(false);
            //_ = await GetSalesActivityOutcomesByID();
        }

        [Fact]
        public async Task GetDealProductsOnSuccess()
        {
            _ = await GetDealProducts();
        }

        [Fact]
        public async Task GetDealStagesOnSuccess()
        {
            _ = await GetDealStages();
        }

        [Fact]
        public async Task GetDealTypesOnSuccess()
        {
            _ = await GetDealTypes();
        }

        [Fact]
        public async Task GetDealReasonsOnSuccess()
        {
            _ = await GetDealReasons();
        }

        [Fact]
        public async Task GetDealPipelinesOnSuccess()
        {
            _ = await GetDealPipelines();
        }

        [Fact]
        public async Task GetDealPipelinesByIDOnSuccess()
        {
            Assert.True(false);
            //_ = await GetDealPipelinesByID();
        }

        [Fact]
        public async Task GetDealPaymentStatusesOnSuccess()
        {
            _ = await GetDealPaymentStatuses();
        }

        [Fact]
        public async Task GetTerritoriesOnSuccess()
        {
            _ = await GetTerritories();
        }

        [Fact]
        public async Task GetCampaignsOnSuccess()
        {
            _ = await GetCampaigns();
        }

        [Fact]
        public async Task GetOwnersOnSuccess()
        {
            _ = await GetOwners();
        }

        [Fact]
        public async Task GetCurrenciesOnSuccess()
        {
            _ = await GetCurrencies();
        }

        [Fact]
        public async Task GetContactStatusesOnSuccess()
        {
            _ = await GetContactStatuses();
        }

        [Fact]
        public async Task GetBusinessTypesOnSuccess()
        {
            _ = await GetBusinessTypes();
        }

        [Fact]
        public async Task GetLifecycleStagesOnSuccess()
        {
            _ = await GetLifecycleStages();
        }

        [Fact]
        public async Task GetIndustryTypesOnSuccess()
        {
            _ = await GetIndustryTypes();
        }

        public async Task<object> GetSalesActivityTypes()
        {
            var result = await _client.Selector.GetSalesActivityTypes();
            //var result = await _client.Query().GetSalesActivityTypes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;
        }

        public async Task<object> GetSalesActivityEntityTypes()
        {
            var result = await _client.Selector.GetSalesActivityEntityTypes();
            //var result = await _client.Query().GetSalesActivityEntityTypes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;
        }

        public async Task<object> GetSalesActivityOutcomes()
        {
            var result = await _client.Selector.GetSalesActivityOutcomes();
            //var result = await _client.Query().GetSalesActivityOutcomes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;
        }

        public async Task<object> GetSalesActivityOutcomesByID(long id)
        {
            var result = await _client.Selector.GetSalesActivityOutcomesByID(id);
            //var result = await _client.Query().GetSalesActivityOutcomesByID(id);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;

        }

        public async Task<object> GetDealProducts()
        {
            var result = await _client.Selector.GetDealProducts();
            //var result = await _client.Query().GetDealProducts();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;

        }

        public async Task<object> GetDealStages()
        {
            var result = await _client.Selector.GetDealStages();
            //var result = await _client.Query().GetDealStages();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;

        }

        public async Task<object> GetDealTypes()
        {
            var result = await _client.Selector.GetDealTypes();
            //var result = await _client.Query().GetDealTypes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;

        }

        public async Task<object> GetDealReasons()
        {
            var result = await _client.Selector.GetDealReasons();
            //var result = await _client.Query().GetDealReasons();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;

        }

        public async Task<object> GetDealPipelines()
        {
            var result = await _client.Selector.GetDealPipelines();
            //var result = await _client.Query().GetDealPipelines();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;

        }

        public async Task<object> GetDealPipelinesByID(long id)
        {
            var result = await _client.Selector.GetDealPipelinesByID(id);
            //var result = await _client.Query().GetDealPipelinesByID(id);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;

        }

        public async Task<object> GetDealPaymentStatuses()
        {
            var result = await _client.Selector.GetDealPaymentStatuses();
            //var result = await _client.Query().GetDealPaymentStatuses();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;

        }

        public async Task<object> GetTerritories()
        {
            var result = await _client.Selector.GetTerritories();
            //var result = await _client.Query().GetTerritories();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;

        }

        public async Task<object> GetCampaigns()
        {
            var result = await _client.Selector.GetCampaigns();
            //var result = await _client.Query().GetCampaigns();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;

        }

        public async Task<List<User>> GetOwners()
        {
            var result = await _client.Selector.GetOwners();
            //var result = await _client.Query().GetOwners();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);

            var selector = result.Content as Selector;
            return selector.Users;
        }

        public async Task<object> GetCurrencies()
        {
            var result = await _client.Selector.GetCurrencies();
            //var result = await _client.Query().GetCurrencies();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;

        }

        public async Task<object> GetContactStatuses()
        {
            var result = await _client.Selector.GetContactStatuses();
            //var result = await _client.Query().GetContactStatuses();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;

        }

        public async Task<object> GetBusinessTypes()
        {
            var result = await _client.Selector.GetBusinessTypes();
            //var result = await _client.Query().GetBusinessTypes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;

        }

        public async Task<object> GetLifecycleStages()
        {
            var result = await _client.Selector.GetLifecycleStages();
            //var result = await _client.Query().GetLifecycleStages();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;

        }

        public async Task<object> GetIndustryTypes()
        {
            var result = await _client.Selector.GetIndustryTypes();
            //var result = await _client.Query().GetIndustryTypes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            
            return result.Content;

        }
    
    }
}
