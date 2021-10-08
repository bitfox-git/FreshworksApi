using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Selectors
{
    public class SelectorController : Network
    {
        /// <summary>
        /// Get data of all deals.
        /// </summary>
        public readonly SelectorDeals Deals;

        /// <summary>
        /// Get data of all sales.
        /// </summary>
        public readonly SelectorSales Sales;

        public SelectorController(string baseURL, string apikey): base($"{baseURL}/api/selector", apikey)
        {
            Deals = new SelectorDeals($"{baseURL}/api/selector", apikey);
            Sales = new SelectorSales($"{baseURL}/api/selector", apikey);
        }

        // All Owners
        public async Task<SelectorParent> GetOwners(Params _params=null)
        {
            string path = $"/owners";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<SelectorParent>(path);
        }

        // Available currencies
        public async Task<SelectorParent> GetCurrencies(Params _params=null)
        {
            string path = $"/currencies";
            return await GetApiRequest<SelectorParent>(path);
        }

        // All Business types 
        public async Task<SelectorParent> GetBusinessTypes(Params _params=null)
        {
            string path = $"/business_types";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<SelectorParent>(path);
        }

        // All statuses of contact
        public async Task<SelectorParent> GetContactStatuses(Params _params=null)
        {
            string path = $"/contact_statuses";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<SelectorParent>(path);
        }

        // All Lifecycle stages
        public async Task<SelectorParent> GetLifecycleStages(Params _params=null)
        {
            string path = $"/lifecycle_stages";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<SelectorParent>(path);
        }

        // All industry types
        public async Task<SelectorParent> GetIndustryTypes(Params _params=null)
        {
            string path = $"/industry_types";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<SelectorParent>(path);
        }
    }
}
