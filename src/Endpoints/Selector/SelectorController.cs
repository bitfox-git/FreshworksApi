using Bitfox.Freshworks.Endpoints.Selector;
using Bitfox.Freshworks.Endpoints.Selector.Response;
using Bitfox.Freshworks.Models;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Selectors
{
    public class SelectorController : Network
    {
        /// <summary>
        /// Get data of all deals.
        /// </summary>
        public readonly DealController Deals;

        /// <summary>
        /// Get data of all sales.
        /// </summary>
        public readonly SaleController Sales;

        public SelectorController(string baseURL, string apikey): base($"{baseURL}/api/selector", apikey)
        {
            Deals = new DealController($"{baseURL}/api/selector", apikey);
            Sales = new SaleController($"{baseURL}/api/selector", apikey);
        }

        // All Territories
        public async Task<TerritoriesResponse> GetTerritories(Params _params = null)
        {
            string path = $"/territories";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<TerritoriesResponse>(path);
        }

        // All Campaigns
        public async Task<CampaignsResponse> GetCampaigns(Params _params=null)
        {
            string path = $"/campaigns";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<CampaignsResponse>(path);
        }

        // All Owners
        public async Task<UsersResponse> GetOwners(Params _params = null)
        {
            string path = $"/owners";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<UsersResponse>(path);
        }

        // Available currencies
        public async Task<CurrenciesResponse> GetCurrencies(Params _params=null)
        {
            string path = $"/currencies";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<CurrenciesResponse>(path);
        }

        // All statuses of contact
        public async Task<ContactStatusesResponse> GetContactStatuses(Params _params=null)
        {
            string path = $"/contact_statuses";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<ContactStatusesResponse>(path);
        }

        // All Business types 
        public async Task<BusinessTypesResponse> GetBusinessTypes(Params _params=null)
        {
            string path = $"/business_types";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<BusinessTypesResponse>(path);
        }

        // All Lifecycle stages
        public async Task<LifecycleStagesResponse> GetLifecycleStages(Params _params=null)
        {
            string path = $"/lifecycle_stages";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<LifecycleStagesResponse>(path);
        }

        // All industry types
        public async Task<IndustryTypesResponse> GetIndustryTypes(Params _params=null)
        {
            string path = $"/industry_types";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<IndustryTypesResponse>(path);
        }
    }
}
