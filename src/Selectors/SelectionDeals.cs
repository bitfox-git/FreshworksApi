using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Selectors
{
    public class SelectionDeals: NetworkModel
    {
        private readonly string BaseURL;
        private readonly string ApiKey;

        public SelectionDeals(string baseURL, string apikey)
        {
            BaseURL = baseURL;
            ApiKey = apikey;
        }

        /// <summary>
        /// Fetch all existing deal stages' details of default pipeline in the Freshsales portal.
        /// Will give id, name, deal_pipeline_id of the deal stages.
        /// </summary>
        /// <returns>List of all deal stages</returns>
        public async Task<List<DealStage>> GetStages()
        {
            string url = $"{BaseURL}/api/selector/deal_stages";
            return await GetApiRequest<List<DealStage>>(url, ApiKey, getFirstItem: true);
        }

        /// <summary>
        /// Fetch all existing deal types' details in the Freshsales portal.
        /// Will give id, name of the deal types
        /// </summary>
        /// <returns>List of all deal types</returns>
        public async Task<List<DealStage>> GetTypes()
        {
            string url = $"{BaseURL}/api/selector/deal_types";
            return await GetApiRequest<List<DealStage>>(url, ApiKey, getFirstItem: true);
        }

        /// <summary>
        /// Fetch all existing deal reasons' details in the Freshsales portal.
        /// Will give id, name of the deal reasons
        /// </summary>
        /// <returns>List of all deal reasons</returns>
        public async Task<List<DealStage>> GetReasons()
        {
            string url = $"{BaseURL}/api/selector/deal_reasons";
            return await GetApiRequest<List<DealStage>>(url, ApiKey, getFirstItem: true);
        }

        /// <summary>
        /// Fetch all existing deal pipelines' details in the Freshsales portal.
        /// Will give id, name of the deal pipelines
        /// </summary>
        /// <returns>List of all deal pipelines</returns>
        public async Task<List<DealStage>> GetPipelines()
        {
            string url = $"{BaseURL}/api/selector/deal_pipelines";
            return await GetApiRequest<List<DealStage>>(url, ApiKey, getFirstItem: true);
        }

        /// <summary>
        /// Fetch all existing deal_stages' details only of the pipeline specified.
        /// Will give id, name, deal_pipeline_id of the deal stages.
        /// </summary>
        /// <param name="id">Owner ID</param>
        /// <returns>List of all deal pipelines based on ID</returns>
        public async Task<List<DealStage>> GetPipelinesOnID(long id)
        {
            string url = $"{BaseURL}/api/selector/deal_pipelines/{id}/deal_stages";
            return await GetApiRequest<List<DealStage>>(url, ApiKey, getFirstItem: true);
        }

        /// <summary>
        /// Fetch all existing deal payment statuses' details in the Freshsales portal.
        /// Will give id, name of the deal payment statuses
        /// </summary>
        /// <returns>List of all deal payment statuses</returns>
        public async Task<List<PaymentStatus>> GetPaymentStatuses()
        {
            string url = $"{BaseURL}/api/selector/deal_payment_statuses";
            return await GetApiRequest<List<PaymentStatus>>(url, ApiKey, getFirstItem: true);
        }
    }
}
