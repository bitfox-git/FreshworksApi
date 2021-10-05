using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Selectors
{
    public class SelectionSales: NetworkModel
    {
        private readonly string BaseURL;
        private readonly string ApiKey;

        public SelectionSales(string baseURL, string apikey)
        {
            BaseURL = baseURL;
            ApiKey = apikey;
        }

        /// <summary>
        /// Fetch all existing sales activity types' details in the Freshsales portal.
        /// Will give id, name of the sales activity types.
        /// </summary>
        /// <returns>List of all sales activity types</returns>
        public async Task<List<SalesActivityType>> GetActivityTypes()
        {
            string url = $"{BaseURL}/api/selector/sales_activity_types";
            return await GetApiRequest<List<SalesActivityType>>(url, ApiKey, getFirstItem:true);
        }

        /// <summary>
        /// Fetch all existing sales activity entity types' details in the Freshsales portal.
        /// Will give id, name of the sales activity entity types.
        /// </summary>
        /// <returns>List of all sales activity entity types</returns>
        public async Task<List<SalesActivityType>> GetActivityEntityTypes()
        {
            string url = $"{BaseURL}/api/selector/sales_activity_entity_types";
            return await GetApiRequest<List<SalesActivityType>>(url, ApiKey, getFirstItem: true);
        }

        /// <summary>
        /// Fetch all existing sales activity outcomes' details in the Freshsales portal.
        /// Will give id, name of the sales activity outcomes.
        /// </summary>
        /// <returns>List of all sales activity outcomes</returns>
        public async Task<List<SalesActivityType>> GetActivityOutcomes()
        {
            string url = $"{BaseURL}/api/selector/sales_activity_outcomes";
            return await GetApiRequest<List<SalesActivityType>>(url, ApiKey, getFirstItem: true);
        }

        /// <summary>
        /// Fetch all existing sales activity outcomes' details only of the sales activity type specified.
        /// Will give id, name, sales_activity_type_id of the sales activity outcomes.
        /// </summary>
        /// <returns>List of all sales activity outcomes based on ID</returns>
        public async Task<List<SalesActivityType>> GetActivityOutcomesOnID(long id)
        {
            string url = $"{BaseURL}/api/selector/sales_activity_types/{id}/sales_activity_outcomes";
            return await GetApiRequest<List<SalesActivityType>>(url, ApiKey, getFirstItem: true);
        }
    }
}
