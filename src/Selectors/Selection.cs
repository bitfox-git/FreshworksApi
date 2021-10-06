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
    public class Selection : NetworkModel
    {
        /// <summary>
        /// Get data of all deals.
        /// </summary>
        public readonly SelectionDeals Deals;

        /// <summary>
        /// Get data of all sales.
        /// </summary>
        public readonly SelectionSales Sales;

        public Selection(string baseURL, string apikey): base(baseURL, apikey)
        {
            Deals = new SelectionDeals(baseURL, apikey);
            Sales = new SelectionSales(baseURL, apikey);
        }

        /// <summary>
        /// Fetch all existing users' details in the Freshsales portal.  
        /// Will give id, name of the users
        /// </summary>
        /// <returns>List of all owners</returns>
        public async Task<UsersObject> GetOwners()
        {
            string path = $"/api/selector/owners";
            return await GetApiRequest<UsersObject>(path);
        }

        /// <summary>
        /// Fetch all existing currency details in the Freshsales portal.
        /// Will give id, currency code and other details of currencies
        /// </summary>
        /// <returns>List of all currencies</returns>
        public async Task<CurrenciesObject> GetCurrencies()
        {
            string path = $"/api/selector/currencies";
            return await GetApiRequest<CurrenciesObject>(path);
        }

        /// <summary>
        /// Fetch all existing business types' details in the Freshsales portal.
        /// Will give id, name of the business types
        /// </summary>
        /// <returns>List of all business types</returns>
        public async Task<BusinessTypesObject> GetBusinessTypes()
        {
            string path = $"/api/selector/business_types";
            return await GetApiRequest<BusinessTypesObject>(path);
        }

        /// <summary>
        /// Fetch all existing contact statuses' details in the Freshsales portal.
        /// Will give id, name of the contact statuses.
        /// </summary>
        /// <returns>List of all contact statuses</returns>
        public async Task<ContactStatusesObject> GetContactStatuses()
        {
            string path = $"/api/selector/contact_statuses";
            return await GetApiRequest<ContactStatusesObject>(path);
        }

        /// <summary>
        /// Fetch all existing lifecycle_stages' details in the Freshsales portal.
        /// Will give id, name and contact statuses of the lifecycle stage.
        /// </summary>
        /// <returns>List of all lifecycle stages</returns>
        public async Task<LifecycleStagesObject> GetLifecycleStages()
        {
            string path = $"/api/selector/lifecycle_stages";
            return await GetApiRequest<LifecycleStagesObject>(path);
        }

        /// <summary>
        /// Fetch all existing industry types' details in the Freshsales portal.
        /// Will give id, name of the industry types
        /// </summary>
        /// <returns>List of all industry types</returns>
        public async Task<IndustryTypesObject> GetIndustryTypes()
        {
            string path = $"/api/selector/industry_types";
            return await GetApiRequest<IndustryTypesObject>(path);
        }
    }
}
