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
        public readonly SelectorDealController Deals;

        /// <summary>
        /// Get data of all sales.
        /// </summary>
        public readonly SelectorSaleController Sales;

        public SelectorController(string baseURL, string apikey): base($"{baseURL}/api/selector", apikey)
        {
            Deals = new SelectorDealController($"{baseURL}/api/selector", apikey);
            Sales = new SelectorSaleController($"{baseURL}/api/selector", apikey);
        }

        // All Territories
        public async Task<TerritoriesResponse> GetTerritories(Params _params = null)
        {
            string path = $"/territories";
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await GetApiRequest<TerritoriesResponse>(path, hasIncludes);
        }

        // All Campaigns
        public async Task<CampaignsResponse> GetCampaigns(Params _params=null)
        {
            string path = $"/campaigns";
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await GetApiRequest<CampaignsResponse>(path, hasIncludes);
        }

        // All Owners
        public async Task<UsersResponse> GetOwners(Params _params = null)
        {
            string path = $"/owners";
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await GetApiRequest<UsersResponse>(path, hasIncludes);
        }

        // Available currencies
        public async Task<CurrenciesResponse> GetCurrencies(Params _params=null)
        {
            string path = $"/currencies";
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await GetApiRequest<CurrenciesResponse>(path, hasIncludes);
        }

        // All statuses of contact
        public async Task<ContactStatusesResponse> GetContactStatuses(Params _params=null)
        {
            string path = $"/contact_statuses";
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await GetApiRequest<ContactStatusesResponse>(path, hasIncludes);
        }

        // All Business types 
        public async Task<BusinessTypesResponse> GetBusinessTypes(Params _params=null)
        {
            string path = $"/business_types";
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await GetApiRequest<BusinessTypesResponse>(path, hasIncludes);
        }

        // All Lifecycle stages
        public async Task<LifecycleStagesResponse> GetLifecycleStages(Params _params=null)
        {
            string path = $"/lifecycle_stages";
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await GetApiRequest<LifecycleStagesResponse>(path, hasIncludes);
        }

        // All industry types
        public async Task<IndustryTypesResponse> GetIndustryTypes(Params _params=null)
        {
            string path = $"/industry_types";
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await GetApiRequest<IndustryTypesResponse>(path, hasIncludes);
        }
    }
}
