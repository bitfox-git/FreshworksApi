using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Selectors
{
    public class SelectorSales: Network
    {
        public SelectorSales(string baseURL, string apikey): base(baseURL, apikey)
        { }

        /// <summary>
        /// Fetch all existing sales activity types' details in the Freshsales portal.
        /// Will give id, name of the sales activity types.
        /// </summary>
        /// <returns>List of all sales activity types</returns>
        public async Task<SelectorParent> GetActivityTypes(string include = null, int? page = null)
        {
            string path = SetParams($"/sales_activity_types", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }

        /// <summary>
        /// Fetch all existing sales activity entity types' details in the Freshsales portal.
        /// Will give id, name of the sales activity entity types.
        /// </summary>
        /// <returns>List of all sales activity entity types</returns>
        public async Task<SelectorParent> GetActivityEntityTypes(string include = null, int? page = null)
        {
            string path = SetParams($"/sales_activity_entity_types", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }

        /// <summary>
        /// Fetch all existing sales activity outcomes' details in the Freshsales portal.
        /// Will give id, name of the sales activity outcomes.
        /// </summary>
        /// <returns>List of all sales activity outcomes</returns>
        public async Task<SelectorParent> GetActivityOutcomes(string include = null, int? page = null)
        {
            string path = SetParams($"/sales_activity_outcomes", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }

        /// <summary>
        /// Fetch all existing sales activity outcomes' details only of the sales activity type specified.
        /// Will give id, name, sales_activity_type_id of the sales activity outcomes.
        /// </summary>
        /// <returns>List of all sales activity outcomes based on ID</returns>
        public async Task<SelectorParent> GetActivityOutcomesOnID(long id, string include = null, int? page = null)
        {
            string path = SetParams($"/sales_activity_types/{id}/sales_activity_outcomes", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }
    }
}
