using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Selectors
{
    public class SelectionSales: NetworkModel
    {
        public SelectionSales(string baseURL, string apikey): base(baseURL, apikey)
        { }

        /// <summary>
        /// Fetch all existing sales activity types' details in the Freshsales portal.
        /// Will give id, name of the sales activity types.
        /// </summary>
        /// <returns>List of all sales activity types</returns>
        public async Task<SalesTypesObject> GetActivityTypes()
        {
            string path = $"/api/selector/sales_activity_types";
            return await GetApiRequest<SalesTypesObject>(path);
        }

        /// <summary>
        /// Fetch all existing sales activity entity types' details in the Freshsales portal.
        /// Will give id, name of the sales activity entity types.
        /// </summary>
        /// <returns>List of all sales activity entity types</returns>
        public async Task<SalesEntityTypesObject> GetActivityEntityTypes()
        {
            string path = $"/api/selector/sales_activity_entity_types";
            return await GetApiRequest<SalesEntityTypesObject>(path);
        }

        /// <summary>
        /// Fetch all existing sales activity outcomes' details in the Freshsales portal.
        /// Will give id, name of the sales activity outcomes.
        /// </summary>
        /// <returns>List of all sales activity outcomes</returns>
        public async Task<SalesOutcomesObject> GetActivityOutcomes()
        {
            string path = $"/api/selector/sales_activity_outcomes";
            return await GetApiRequest<SalesOutcomesObject>(path);
        }

        /// <summary>
        /// Fetch all existing sales activity outcomes' details only of the sales activity type specified.
        /// Will give id, name, sales_activity_type_id of the sales activity outcomes.
        /// </summary>
        /// <returns>List of all sales activity outcomes based on ID</returns>
        public async Task<SalesOutcomesObject> GetActivityOutcomesOnID(long id)
        {
            string path = $"/api/selector/sales_activity_types/{id}/sales_activity_outcomes";
            return await GetApiRequest<SalesOutcomesObject>(path);
        }
    }
}
