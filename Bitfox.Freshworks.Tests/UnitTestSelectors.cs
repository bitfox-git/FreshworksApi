using Bitfox.Freshworks.Endpoints.Selector;
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

        public async Task<Selector> GetSalesActivityTypes()
        {
            var result = await _client.GetOwners();
            //var result = await _client.Selector.GetOwners();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);
        }

        public async Task<Selector> GetSalesActivityEntityTypes()
        {
            var result = await _client.GetSalesActivityEntityTypes();
            //var result = await _client.Selector.GetSalesActivityEntityTypes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);
        }

        public async Task<Selector> GetSalesActivityOutcomes()
        {
            var result = await _client.GetSalesActivityOutcomes();
            //var result = await _client.Selector.GetSalesActivityOutcomes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);
        }

        public async Task<Selector> GetSalesActivityOutcomesByID(long id)
        {
            var result = await _client.GetSalesActivityOutcomesByID(id);
            //var result = await _client.Selector.GetSalesActivityOutcomesByID(id);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);

        }

        public async Task<Selector> GetDealProducts()
        {
            var result = await _client.GetDealProducts();
            //var result = await _client.Selector.GetDealProducts();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);

        }

        public async Task<Selector> GetDealStages()
        {
            var result = await _client.GetDealStages();
            //var result = await _client.Selector.GetDealStages();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);

        }

        public async Task<Selector> GetDealTypes()
        {
            var result = await _client.GetDealTypes();
            //var result = await _client.Selector.GetDealTypes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);

        }

        public async Task<Selector> GetDealReasons()
        {
            var result = await _client.GetDealReasons();
            //var result = await _client.Selector.GetDealReasons();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);

        }

        public async Task<Selector> GetDealPipelines()
        {
            var result = await _client.GetDealPipelines();
            //var result = await _client.Selector.GetDealPipelines();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);

        }

        public async Task<Selector> GetDealPipelinesByID(long id)
        {
            var result = await _client.GetDealPipelinesByID(id);
            //var result = await _client.Selector.GetDealPipelinesByID(id);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);

        }

        public async Task<Selector> GetDealPaymentStatuses()
        {
            var result = await _client.GetDealPaymentStatuses();
            //var result = await _client.Selector.GetDealPaymentStatuses();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);

        }

        public async Task<Selector> GetTerritories()
        {
            var result = await _client.GetTerritories();
            //var result = await _client.Selector.GetTerritories();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);

        }

        public async Task<Selector> GetCampaigns()
        {
            var result = await _client.GetCampaigns();
            //var result = await _client.Selector.GetCampaigns();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);

        }

        public async Task<Selector> GetOwners()
        {
            var result = await _client.GetOwners();
            //var result = await _client.Selector.GetOwners();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);
        }

        public async Task<Selector> GetCurrencies()
        {
            var result = await _client.GetCurrencies();
            //var result = await _client.Selector.GetCurrencies();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);

        }

        public async Task<Selector> GetContactStatuses()
        {
            var result = await _client.GetContactStatuses();
            //var result = await _client.Selector.GetContactStatuses();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);

        }

        public async Task<Selector> GetBusinessTypes()
        {
            var result = await _client.GetBusinessTypes();
            //var result = await _client.Selector.GetBusinessTypes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);

        }

        public async Task<Selector> GetLifecycleStages()
        {
            var result = await _client.GetLifecycleStages();
            //var result = await _client.Selector.GetLifecycleStages();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);

        }

        public async Task<Selector> GetIndustryTypes()
        {
            var result = await _client.GetIndustryTypes();
            //var result = await _client.Selector.GetIndustryTypes();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result);

        }

        private Selector GetResponse<TEntity>(Result<TEntity> result)
        {
            // Result
            if (result.Content != null)
            {
                Selector selector = (result.Content as Selector);
                _console.WriteLine($"The result content type: {result.Content.GetType()}");
                return selector;
            }
            else
            {
                _console.WriteLine($"The result error message: {result.Error.Message}");
                return null;
            }
        }

    }
}
