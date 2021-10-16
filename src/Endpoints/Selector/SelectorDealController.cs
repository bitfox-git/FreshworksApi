using Bitfox.Freshworks.Endpoints.Selector;
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
    public class SelectorDealController//: Network
    {
        public SelectorDealController(string baseURL, string apikey)//: base(baseURL, apikey)
        { }

        ///// <summary>
        ///// Fetch all existing deal stages' details of default pipeline in the Freshsales portal.
        ///// Will give id, name, deal_pipeline_id of the deal stages.
        ///// </summary>
        ///// <returns>List of all deal stages</returns>
        //public async Task<DealsResponse> GetProducts(Params _params = null)
        //{
        //    string path = $"/deal_products";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await GetApiRequest<DealsResponse>(path, hasIncludes);
        //}

        ///// <summary>
        ///// Fetch all existing deal stages' details of default pipeline in the Freshsales portal.
        ///// Will give id, name, deal_pipeline_id of the deal stages.
        ///// </summary>
        ///// <returns>List of all deal stages</returns>
        //public async Task<DealsResponse> GetStages(Params _params=null)
        //{
        //    string path = $"/deal_stages";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await GetApiRequest<DealsResponse>(path, hasIncludes);
        //}

        ///// <summary>
        ///// Fetch all existing deal types' details in the Freshsales portal.
        ///// Will give id, name of the deal types
        ///// </summary>
        ///// <returns>List of all deal types</returns>
        //public async Task<DealsResponse> GetTypes(Params _params=null)
        //{
        //    string path = $"/deal_types";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await GetApiRequest<DealsResponse>(path, hasIncludes);
        //}

        ///// <summary>
        ///// Fetch all existing deal reasons' details in the Freshsales portal.
        ///// Will give id, name of the deal reasons
        ///// </summary>
        ///// <returns>List of all deal reasons</returns>
        //public async Task<DealsResponse> GetReasons(Params _params=null)
        //{
        //    string path = $"/deal_reasons";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await GetApiRequest<DealsResponse>(path, hasIncludes);
        //}

        ///// <summary>
        ///// Fetch all existing deal pipelines' details in the Freshsales portal.
        ///// Will give id, name of the deal pipelines
        ///// </summary>
        ///// <returns>List of all deal pipelines</returns>
        //public async Task<DealsResponse> GetPipelines(Params _params=null)
        //{
        //    string path = $"/deal_pipelines";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await GetApiRequest<DealsResponse>(path, hasIncludes);
        //}

        ///// <summary>
        ///// Fetch all existing deal_stages' details only of the pipeline specified.
        ///// Will give id, name, deal_pipeline_id of the deal stages.
        ///// </summary>
        ///// <param name="id">Owner ID</param>
        ///// <returns>List of all deal pipelines based on ID</returns>
        //public async Task<DealsResponse> GetPipelinesOnID(long id, Params _params=null)
        //{
        //    string path = $"/deal_pipelines/{id}/deal_stages";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await GetApiRequest<DealsResponse>(path, hasIncludes);
        //}

        ///// <summary>
        ///// Fetch all existing deal payment statuses' details in the Freshsales portal.
        ///// Will give id, name of the deal payment statuses
        ///// </summary>
        ///// <returns>List of all deal payment statuses</returns>
        //public async Task<DealsResponse> GetPaymentStatuses(Params _params=null)
        //{
        //    string path = $"/deal_payment_statuses";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await GetApiRequest<DealsResponse>(path, hasIncludes);
        //}
    }
}
