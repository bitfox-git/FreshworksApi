using Bitfox.Freshworks.Endpoints.Selector.Response;
using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Selectors
{
    public class SaleController: Network
    {
        public SaleController(string baseURL, string apikey): base(baseURL, apikey)
        { }

        /// <summary>
        /// Fetch all existing sales activity types' details in the Freshsales portal.
        /// Will give id, name of the sales activity types.
        /// </summary>
        /// <returns>List of all sales activity types</returns>
        public async Task<SalesResponse> GetActivityTypes(Params _params=null)
        {
            string path = $"/sales_activity_types";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<SalesResponse>(path);
        }

        /// <summary>
        /// Fetch all existing sales activity entity types' details in the Freshsales portal.
        /// Will give id, name of the sales activity entity types.
        /// </summary>
        /// <returns>List of all sales activity entity types</returns>
        public async Task<SalesResponse> GetActivityEntityTypes(Params _params=null)
        {
            string path = $"/sales_activity_entity_types";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<SalesResponse>(path);
        }

        /// <summary>
        /// Fetch all existing sales activity outcomes' details in the Freshsales portal.
        /// Will give id, name of the sales activity outcomes.
        /// </summary>
        /// <returns>List of all sales activity outcomes</returns>
        public async Task<SalesResponse> GetActivityOutcomes(Params _params=null)
        {
            string path = $"/sales_activity_outcomes";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<SalesResponse>(path);
        }

        /// <summary>
        /// Fetch all existing sales activity outcomes' details only of the sales activity type specified.
        /// Will give id, name, sales_activity_type_id of the sales activity outcomes.
        /// </summary>
        /// <returns>List of all sales activity outcomes based on ID</returns>
        public async Task<SalesResponse> GetActivityOutcomesOnID(long id, Params _params=null)
        {
            string path = $"/sales_activity_types/{id}/sales_activity_outcomes";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<SalesResponse>(path);
        }
    }
}
