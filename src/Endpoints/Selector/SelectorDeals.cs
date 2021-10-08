using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Selectors
{
    public class SelectorDeals: Network
    {
        public SelectorDeals(string baseURL, string apikey): base(baseURL, apikey)
        { }

        /// <summary>
        /// Fetch all existing deal stages' details of default pipeline in the Freshsales portal.
        /// Will give id, name, deal_pipeline_id of the deal stages.
        /// </summary>
        /// <returns>List of all deal stages</returns>
        public async Task<SelectorParent> GetStages(string include = null, int? page = null)
        {
            string path = SetParams($"/deal_stages", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }

        /// <summary>
        /// Fetch all existing deal types' details in the Freshsales portal.
        /// Will give id, name of the deal types
        /// </summary>
        /// <returns>List of all deal types</returns>
        public async Task<SelectorParent> GetTypes(string include = null, int? page = null)
        {
            string path = SetParams($"/deal_types", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }

        /// <summary>
        /// Fetch all existing deal reasons' details in the Freshsales portal.
        /// Will give id, name of the deal reasons
        /// </summary>
        /// <returns>List of all deal reasons</returns>
        public async Task<SelectorParent> GetReasons(string include = null, int? page = null)
        {
            string path = SetParams($"/deal_reasons", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }

        /// <summary>
        /// Fetch all existing deal pipelines' details in the Freshsales portal.
        /// Will give id, name of the deal pipelines
        /// </summary>
        /// <returns>List of all deal pipelines</returns>
        public async Task<SelectorParent> GetPipelines(string include = null, int? page = null)
        {
            string path = SetParams($"/deal_pipelines", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }

        /// <summary>
        /// Fetch all existing deal_stages' details only of the pipeline specified.
        /// Will give id, name, deal_pipeline_id of the deal stages.
        /// </summary>
        /// <param name="id">Owner ID</param>
        /// <returns>List of all deal pipelines based on ID</returns>
        public async Task<SelectorParent> GetPipelinesOnID(long id, string include = null, int? page = null)
        {
            string path = SetParams($"/deal_pipelines/{id}/deal_stages", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }

        /// <summary>
        /// Fetch all existing deal payment statuses' details in the Freshsales portal.
        /// Will give id, name of the deal payment statuses
        /// </summary>
        /// <returns>List of all deal payment statuses</returns>
        public async Task<SelectorParent> GetPaymentStatuses(string include = null, int? page = null)
        {
            string path = SetParams($"/deal_payment_statuses", include, page);
            return await GetApiRequest<SelectorParent>(path);
        }
    }
}
