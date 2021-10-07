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
    public class BaseController : NetworkModel, ISelectorController
    {
        /// <summary>
        /// Get data of all deals.
        /// </summary>
        public readonly SelectionDeals Deals;

        /// <summary>
        /// Get data of all sales.
        /// </summary>
        public readonly SelectionSales Sales;

        public BaseController(string baseURL, string apikey): base(baseURL, apikey)
        {
            Deals = new SelectionDeals(baseURL, apikey);
            Sales = new SelectionSales(baseURL, apikey);
        }

        // All Owners
        public async Task<UsersObject> GetOwners()
        {
            string path = $"/owners";
            return await GetApiRequest<UsersObject>(path);
        }

        // Available currencies
        public async Task<CurrenciesObject> GetCurrencies()
        {
            string path = $"/currencies";
            return await GetApiRequest<CurrenciesObject>(path);
        }

        // All Business types 
        public async Task<BusinessTypesObject> GetBusinessTypes()
        {
            string path = $"/business_types";
            return await GetApiRequest<BusinessTypesObject>(path);
        }

        // All statuses of contact
        public async Task<ContactStatusesObject> GetContactStatuses()
        {
            string path = $"/contact_statuses";
            return await GetApiRequest<ContactStatusesObject>(path);
        }

        // All Lifecycle stages
        public async Task<LifecycleStagesObject> GetLifecycleStages()
        {
            string path = $"/lifecycle_stages";
            return await GetApiRequest<LifecycleStagesObject>(path);
        }

        // All industry types
        public async Task<IndustryTypesObject> GetIndustryTypes()
        {
            string path = $"/industry_types";
            return await GetApiRequest<IndustryTypesObject>(path);
        }
    }
}
