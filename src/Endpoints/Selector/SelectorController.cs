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
    public class SelectorController : NetworkModel
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
        public async Task<SelectorParent> GetOwners()
        {
            string path = $"/owners";
            return await GetApiRequest<SelectorParent>(path);
        }

        // Available currencies
        public async Task<SelectorParent> GetCurrencies()
        {
            string path = $"/currencies";
            return await GetApiRequest<SelectorParent>(path);
        }

        // All Business types 
        public async Task<SelectorParent> GetBusinessTypes()
        {
            string path = $"/business_types";
            return await GetApiRequest<SelectorParent>(path);
        }

        // All statuses of contact
        public async Task<SelectorParent> GetContactStatuses()
        {
            string path = $"/contact_statuses";
            return await GetApiRequest<SelectorParent>(path);
        }

        // All Lifecycle stages
        public async Task<SelectorParent> GetLifecycleStages()
        {
            string path = $"/lifecycle_stages";
            return await GetApiRequest<SelectorParent>(path);
        }

        // All industry types
        public async Task<SelectorParent> GetIndustryTypes()
        {
            string path = $"/industry_types";
            return await GetApiRequest<SelectorParent>(path);
        }
    }
}
