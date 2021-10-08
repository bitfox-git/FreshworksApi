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
        public async Task<SelectorParent> GetOwners(string include = null, int? page = null)
        {
            string path = SetParams($"/owners", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }

        // Available currencies
        public async Task<SelectorParent> GetCurrencies(string include = null, int? page = null)
        {
            string path = SetParams($"/currencies", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }

        // All Business types 
        public async Task<SelectorParent> GetBusinessTypes(string include = null, int? page = null)
        {
            string path = SetParams($"/business_types", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }

        // All statuses of contact
        public async Task<SelectorParent> GetContactStatuses(string include = null, int? page = null)
        {
            string path = SetParams($"/contact_statuses", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }

        // All Lifecycle stages
        public async Task<SelectorParent> GetLifecycleStages(string include = null, int? page = null)
        {
            string path = SetParams($"/lifecycle_stages", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }

        // All industry types
        public async Task<SelectorParent> GetIndustryTypes(string include = null, int? page = null)
        {
            string path = SetParams($"/industry_types", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }
    }
}
