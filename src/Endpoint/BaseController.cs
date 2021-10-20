﻿
using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.Endpoints.Selector;
using Bitfox.Freshworks.NetworkModels;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class BaseController : Network
    {
        public BaseController(string baseURL, string apikey) : base(baseURL, apikey)
        { }

        // Base







        // Selectors
        
        public async Task<Result<Selector>> GetSalesActivityTypes()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/sales_activity_types";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetSalesActivityEntityTypes()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/sales_activity_entity_types";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetSalesActivityOutcomes()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/sales_activity_outcomes";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetSalesActivityOutcomesByID(long id)
        {
            string endpoint = $"{GetEndpoint<Selector>()}/sales_activity_types/{id}/sales_activity_outcomes";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetDealProducts()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/deal_products";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetDealStages()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/deal_stages";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetDealTypes()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/deal_types";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetDealReasons()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/deal_reasons";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetDealPipelines()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/deal_pipelines";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetDealPipelinesByID(long id)
        {
            string endpoint = $"{GetEndpoint<Selector>()}/deal_pipelines/{id}/deal_stages";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetDealPaymentStatuses()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/deal_payment_statuses";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetTerritories()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/territories";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetCampaigns()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/campaigns";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetOwners()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/owners";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetCurrencies()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/currencies";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetContactStatuses()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/contact_statuses";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetBusinessTypes()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/business_types";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetLifecycleStages()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/lifecycle_stages";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetIndustryTypes()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/industry_types";
            return await GetApiRequest<Selector>(endpoint);
        }






























        //// Get All Fields 
        //public async Task<TResponse> GetAllFields(string path, Params _params = null)
        //{
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await GetApiRequest<TResponse>(path, hasIncludes);
        //}











        //// View item
        //public async Task<TResponse> GetByID(long id, Params _params = null)
        //{
        //    string path = $"/{id}";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await GetApiRequest<TResponse>(path, hasIncludes);
        //}

        //// View items
        //public async Task<TResponse> GetAllByID(long id, Params _params = null)
        //{
        //    string path = $"/view/{id}";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await GetApiRequest<TResponse>(path, hasIncludes);
        //}

        //// Update Item on ID
        //public async Task<TResponse> UpdateView(long id, TResponse payload, Params _params = null)
        //{
        //    string path = $"/{id}";
        //    path = _params == null ? path : _params.AddPath(path);

        //    return await UpdateApiRequest<TResponse>(path, payload);
        //}






        //// Insert item
        //// Deprecated:
        //public async Task<TResponse> Insert(TRequest payload, Params _params = null)
        //{
        //    string path = $"/";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await PostApiRequest<TRequest, TResponse>(path, payload, hasIncludes);
        //}

        ////// Get Items on content ID
        ////public async Task<TResponse> GetAllByID(long id, Params _params=null)
        ////{
        ////    string path = $"/view/{id}";
        ////    path = _params == null ? path : _params.AddPath(path);
        ////    bool hasIncludes = _params != null && _params.Includes != null;

        ////    return await GetApiRequest<TResponse>(path, hasIncludes);
        ////}

        ////// Get Item on ID
        ////public async Task<TResponse> GetByID(long id, Params _params=null)
        ////{
        ////    string path = $"/{id}";
        ////    path = _params == null ? path : _params.AddPath(path);
        ////    bool hasIncludes = _params != null && _params.Includes != null;

        ////    return await GetApiRequest<TResponse>(path, hasIncludes);
        ////}

        //// Update Item on ID
        //public async Task<TResponse> UpdateByID(long id, TRequest payload, Params _params = null)
        //{
        //    string path = $"/{id}";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await UpdateApiRequest<TRequest, TResponse>(path, payload, hasIncludes);
        //}

        //// Delete Item on ID
        //public async Task<bool> DeleteByID(long id, Params _params = null)
        //{
        //    string path = $"/{id}";
        //    path = _params == null ? path : _params.AddPath(path);

        //    return await DeleteApiRequest(path);
        //}

        //// Clone Item Defined with ID
        //public async Task<TResponse> CloneByID(long id, TRequest body, Params _params = null)
        //{
        //    string path = $"/{id}/clone";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await PostApiRequest<TRequest, TResponse>(path, body, hasIncludes);
        //}

        //// Forget Item by giving ID
        //public async Task<bool> ForgetByID(long id, Params _params = null)
        //{
        //    string path = $"/{id}/forget";
        //    path = _params == null ? path : _params.AddPath(path);

        //    return await DeleteApiRequest(path);
        //}

        //// Insert Bulk of item IDs
        //public async Task<TResponse> CreateBulk(BulkAssign body, Params _params = null)
        //{
        //    string path = $"/bulk_assign_owner";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await PostApiRequest<BulkAssign, TResponse>(path, body, hasIncludes);
        //}

        //// Delete Bulk of item IDs
        //public async Task<TResponse> DeleteBulk(BulkDelete body, Params _params = null)
        //{
        //    string path = $"/bulk_destroy";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await PostApiRequest<BulkDelete, TResponse>(path, body, hasIncludes);
        //}


        //// Get All Activities
        //public async Task<TResponse> GetAllActivitiesByID(long id, Params _params = null)
        //{
        //    string path = $"/{id}/activities.json";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await GetApiRequest<TResponse>(path, hasIncludes);
        //}

    }



    ///// <summary>
    ///// Base Controller controls most used requests.
    ///// </summary>
    ///// <typeparam name="TRequest">Model used as payload in requests</typeparam>
    ///// <typeparam name="TResponse">Model for all responses</typeparam>
    //public class BaseController<TRequest, TResponse> : Network where TResponse : IIncludes
    //{
    //    public BaseController(string baseURL, string apikey): base(baseURL, apikey)
    //    { }

    //    public async Task<T> Create<T>(T body) where T : IHasInsert
    //    {
    //        string endpoint = GetEndpoint<T>();
    //        return await PostApiRequest(endpoint, body);
    //    }


    //    // View item
    //    public async Task<TResponse> GetByID(long id, Params _params = null)
    //    {
    //        string path = $"/{id}";
    //        path = _params == null ? path : _params.AddPath(path);
    //        bool hasIncludes = _params != null && _params.Includes != null;

    //        return await GetApiRequest<TResponse>(path, hasIncludes);
    //    }

    //    // View items
    //    public async Task<TResponse> GetAllByID(long id, Params _params = null)
    //    {
    //        string path = $"/view/{id}";
    //        path = _params == null ? path : _params.AddPath(path);
    //        bool hasIncludes = _params != null && _params.Includes != null;

    //        return await GetApiRequest<TResponse>(path, hasIncludes);
    //    }

    //    // Update Item on ID
    //    public async Task<TResponse> UpdateView(long id, TResponse payload, Params _params = null)
    //    {
    //        string path = $"/{id}";
    //        path = _params == null ? path : _params.AddPath(path);

    //        return await UpdateApiRequest<TResponse>(path, payload);
    //    }






    //    // Insert item
    //    // Deprecated:
    //    public async Task<TResponse> Create(TRequest payload, Params _params=null) 
    //    {
    //        string path = $"/";
    //        path = _params == null ? path : _params.AddPath(path);
    //        bool hasIncludes = _params != null && _params.Includes != null;

    //        return await PostApiRequest<TRequest, TResponse>(path, payload, hasIncludes);
    //    }

    //    //// Get Items on content ID
    //    //public async Task<TResponse> GetAllByID(long id, Params _params=null)
    //    //{
    //    //    string path = $"/view/{id}";
    //    //    path = _params == null ? path : _params.AddPath(path);
    //    //    bool hasIncludes = _params != null && _params.Includes != null;

    //    //    return await GetApiRequest<TResponse>(path, hasIncludes);
    //    //}

    //    //// Get Item on ID
    //    //public async Task<TResponse> GetByID(long id, Params _params=null)
    //    //{
    //    //    string path = $"/{id}";
    //    //    path = _params == null ? path : _params.AddPath(path);
    //    //    bool hasIncludes = _params != null && _params.Includes != null;

    //    //    return await GetApiRequest<TResponse>(path, hasIncludes);
    //    //}

    //    // Update Item on ID
    //    public async Task<TResponse> UpdateByID(long id, TRequest payload, Params _params=null)
    //    {
    //        string path = $"/{id}";
    //        path = _params == null ? path : _params.AddPath(path);
    //        bool hasIncludes = _params != null && _params.Includes != null;

    //        return await UpdateApiRequest<TRequest, TResponse>(path, payload, hasIncludes);
    //    }

    //    // Delete Item on ID
    //    //public async Task<bool> DeleteByID(long id, Params _params=null)
    //    //{
    //    //    string path = $"/{id}";
    //    //    path = _params == null ? path : _params.AddPath(path);

    //    //    return await DeleteApiRequest(path);
    //    //}

    //    // Clone Item Defined with ID
    //    public async Task<TResponse> CloneByID(long id, TRequest body, Params _params=null)
    //    {
    //        string path = $"/{id}/clone";
    //        path = _params == null ? path : _params.AddPath(path);
    //        bool hasIncludes = _params != null && _params.Includes != null;

    //        return await PostApiRequest<TRequest, TResponse>(path, body, hasIncludes);
    //    }

    //    //// Forget Item by giving ID
    //    //public async Task<bool> ForgetByID(long id, Params _params=null)
    //    //{
    //    //    string path = $"/{id}/forget";
    //    //    path = _params == null ? path : _params.AddPath(path);

    //    //    return await DeleteApiRequest(path);
    //    //}

    //    // Insert Bulk of item IDs
    //    public async Task<TResponse> CreateBulk(BulkAssign body, Params _params=null)
    //    {
    //        string path = $"/bulk_assign_owner";
    //        path = _params == null ? path : _params.AddPath(path);
    //        bool hasIncludes = _params != null && _params.Includes != null;

    //        return await PostApiRequest<BulkAssign, TResponse>(path, body, hasIncludes);
    //    }

    //    // Delete Bulk of item IDs
    //    public async Task<TResponse> DeleteBulk(BulkDelete body, Params _params=null)
    //    {
    //        string path = $"/bulk_destroy";
    //        path = _params == null ? path : _params.AddPath(path);
    //        bool hasIncludes = _params != null && _params.Includes != null;

    //        return await PostApiRequest<BulkDelete, TResponse>(path, body, hasIncludes);
    //    }

    //    // Get All Fields 
    //    public async Task<TResponse> GetAllFields(string path, Params _params=null)
    //    {
    //        path = _params == null ? path : _params.AddPath(path);
    //        bool hasIncludes = _params != null && _params.Includes != null;

    //        return await GetApiRequest<TResponse>(path, hasIncludes);
    //    }

    //    // Get All Activities
    //    public async Task<TResponse> GetAllActivitiesByID(long id, Params _params = null)
    //    {
    //        string path = $"/{id}/activities.json";
    //        path = _params == null ? path :_params.AddPath(path);
    //        bool hasIncludes = _params != null && _params.Includes != null;

    //        return await GetApiRequest<TResponse>(path, hasIncludes);
    //    }

    //}
}