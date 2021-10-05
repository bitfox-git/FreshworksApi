using Bitfox.Freshworks.Models;
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
        private readonly string BaseURL;
        private readonly string ApiKey;

        /// <summary>
        /// Get data of all deals.
        /// </summary>
        public readonly SelectionDeals Deals;

        /// <summary>
        /// Get data of all sales.
        /// </summary>
        public readonly SelectionSales Sales;

        public Selection(string baseURL, string apikey)
        {
            BaseURL = baseURL;
            ApiKey = apikey;
            Deals = new SelectionDeals(baseURL, apikey);
            Sales = new SelectionSales(baseURL, apikey);
        }

        /// <summary>
        /// Fetch all existing users' details in the Freshsales portal.  
        /// Will give id, name of the users
        /// </summary>
        /// <returns>List of all owners</returns>
        public async Task<List<User>> GetOwners()
        {
            string url = $"{BaseURL}/api/selector/owners";
            return await GetApiRequest<List<User>>(url, ApiKey, getFirstItem: true);
        }

        /// <summary>
        /// Fetch all existing currency details in the Freshsales portal.
        /// Will give id, currency code and other details of currencies
        /// </summary>
        /// <returns>List of all currencies</returns>
        public async Task<List<Currency>> GetCurrencies()
        {
            string url = $"{BaseURL}/api/selector/currencies";
            return await GetApiRequest<List<Currency>>(url, ApiKey, getFirstItem: true);
        }

        /// <summary>
        /// Fetch all existing business types' details in the Freshsales portal.
        /// Will give id, name of the business types
        /// </summary>
        /// <returns>List of all business types</returns>
        public async Task<List<BusinessType>> GetBusinessTypes()
        {
            string url = $"{BaseURL}/api/selector/business_types";
            return await GetApiRequest<List<BusinessType>>(url, ApiKey, getFirstItem: true);
        }

        /// <summary>
        /// Fetch all existing contact statuses' details in the Freshsales portal.
        /// Will give id, name of the contact statuses.
        /// </summary>
        /// <returns>List of all contact statuses</returns>
        public async Task<List<ContactStatus>> GetContactStatuses()
        {
            string url = $"{BaseURL}/api/selector/contact_statuses";
            return await GetApiRequest<List<ContactStatus>>(url, ApiKey, getFirstItem: true);
        }

        /// <summary>
        /// Fetch all existing lifecycle_stages' details in the Freshsales portal.
        /// Will give id, name and contact statuses of the lifecycle stage.
        /// </summary>
        /// <returns>List of all lifecycle stages</returns>
        public async Task<List<LifecycleStage>> GetLifecycleStages()
        {
            string url = $"{BaseURL}/api/selector/lifecycle_stages";
            return await GetApiRequest<List<LifecycleStage>>(url, ApiKey, getFirstItem: true);
        }

        /// <summary>
        /// Fetch all existing industry types' details in the Freshsales portal.
        /// Will give id, name of the industry types
        /// </summary>
        /// <returns>List of all industry types</returns>
        public async Task<List<IndustryType>> GetIndustryTypes()
        {
            string url = $"{BaseURL}/api/selector/industry_types";
            return await GetApiRequest<List<IndustryType>>(url, ApiKey, getFirstItem: true);
        }
    }
}
