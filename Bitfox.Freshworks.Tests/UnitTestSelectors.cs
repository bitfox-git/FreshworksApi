using Bitfox.Freshworks.Models;
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
            var result = await _client.GetOwners();
            //var result = await _client.object.GetOwners();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;
        }

        public async Task<object> GetSalesActivityEntityTypes()
        {
            var result = await _client.GetSalesActivityEntityTypes();
            //var result = await _client.object.GetSalesActivityEntityTypes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;
        }

        public async Task<object> GetSalesActivityOutcomes()
        {
            var result = await _client.GetSalesActivityOutcomes();
            //var result = await _client.object.GetSalesActivityOutcomes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;
        }

        public async Task<object> GetSalesActivityOutcomesByID(long id)
        {
            var result = await _client.GetSalesActivityOutcomesByID(id);
            //var result = await _client.object.GetSalesActivityOutcomesByID(id);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;

        }

        public async Task<object> GetDealProducts()
        {
            var result = await _client.GetDealProducts();
            //var result = await _client.object.GetDealProducts();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;

        }

        public async Task<object> GetDealStages()
        {
            var result = await _client.GetDealStages();
            //var result = await _client.object.GetDealStages();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;

        }

        public async Task<object> GetDealTypes()
        {
            var result = await _client.GetDealTypes();
            //var result = await _client.object.GetDealTypes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;

        }

        public async Task<object> GetDealReasons()
        {
            var result = await _client.GetDealReasons();
            //var result = await _client.object.GetDealReasons();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;

        }

        public async Task<object> GetDealPipelines()
        {
            var result = await _client.GetDealPipelines();
            //var result = await _client.object.GetDealPipelines();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;

        }

        public async Task<object> GetDealPipelinesByID(long id)
        {
            var result = await _client.GetDealPipelinesByID(id);
            //var result = await _client.object.GetDealPipelinesByID(id);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;

        }

        public async Task<object> GetDealPaymentStatuses()
        {
            var result = await _client.GetDealPaymentStatuses();
            //var result = await _client.object.GetDealPaymentStatuses();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;

        }

        public async Task<object> GetTerritories()
        {
            var result = await _client.GetTerritories();
            //var result = await _client.object.GetTerritories();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;

        }

        public async Task<object> GetCampaigns()
        {
            var result = await _client.GetCampaigns();
            //var result = await _client.object.GetCampaigns();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;

        }

        public async Task<object> GetOwners()
        {
            var result = await _client.GetOwners();
            //var result = await _client.object.GetOwners();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;
        }

        public async Task<object> GetCurrencies()
        {
            var result = await _client.GetCurrencies();
            //var result = await _client.object.GetCurrencies();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;

        }

        public async Task<object> GetContactStatuses()
        {
            var result = await _client.GetContactStatuses();
            //var result = await _client.object.GetContactStatuses();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;

        }

        public async Task<object> GetBusinessTypes()
        {
            var result = await _client.GetBusinessTypes();
            //var result = await _client.object.GetBusinessTypes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;

        }

        public async Task<object> GetLifecycleStages()
        {
            var result = await _client.GetLifecycleStages();
            //var result = await _client.object.GetLifecycleStages();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;

        }

        public async Task<object> GetIndustryTypes()
        {
            var result = await _client.GetIndustryTypes();
            //var result = await _client.object.GetIndustryTypes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content;

        }
    }
}
