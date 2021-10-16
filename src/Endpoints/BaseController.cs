
using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.Endpoints.Selector;
using Bitfox.Freshworks.NetworkModels;
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

        public async Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert
        {
            string endpoint = GetEndpoint<TEntity>();
            return await PostApiRequest(endpoint, body);
        }

        public async Task<Result<TEntity>> Update<TEntity>(TEntity body) where TEntity : IHasUpdate
        {
            if(body.ID == null)
            {
                throw new ArgumentException($"ID is required for updating the view.");
            }

            string endpoint = $"{GetEndpoint<TEntity>()}/{body.ID}";
            return await UpdateApiRequest(endpoint, body);
        }

        public async Task<Result<TEntity>> Clone<TEntity>(TEntity body) where TEntity : IHasClone
        {
            if (body.ID == null)
            {
                throw new ArgumentException($"ID is required for cloning the view.");
            }

            string endpoint = $"{GetEndpoint<TEntity>()}/{body.ID}/clone";
            return await PostApiRequest(endpoint, body);
        }

        public Query Query()
        {
            return new Query(BaseURL, ApiKey);
        }

        public async Task<Result<bool>> Delete<TEntity>(TEntity body) where TEntity : IHasDelete
        {
            return await Delete<TEntity>((long)body.ID);
        }

        public async Task<Result<bool>> Delete<TEntity>(long? id) where TEntity : IHasDelete
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is required for removing the view.");
            }

            string endpoint = $"{GetEndpoint<TEntity>()}/{id}";
            return await DeleteApiRequest(endpoint);
        }
        
        public async Task<Result<TEntity>> DeleteBulk<TEntity>(TEntity body) where TEntity : IHasDeleteBulk
        {
            if (body.SelectedIDs == null)
            {
                throw new ArgumentException($"SelectedIDs is required for removing a bulk.");
            }
            else if (body.DeleteAssociatedContactsDeals == null)
            {
                throw new ArgumentException($"DeleteAssociatedContactsDeals is required for removing a bulk.");
            }

            string endpoint = $"{GetEndpoint<TEntity>()}/bulk_destroy";
            return await PostApiRequest(endpoint, body);
        }

        public async Task<Result<bool>> Forget<TEntity>(TEntity body) where TEntity : IHasForget
        {
            return await Forget<TEntity>((long)body.ID);
        }

        public async Task<Result<bool>> Forget<TEntity>(long? id) where TEntity : IHasForget
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is required for removing the view.");
            }

            string endpoint = $"{GetEndpoint<TEntity>()}/{id}/forget";
            return await DeleteApiRequest(endpoint);
        }

        ///TESTs
        public async Task<Result<Selector>> GetOwners()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/owners";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<TEntity>> GetFilters<TEntity>() where TEntity : IHasFilters
        {
            var endpoint = GetEndpoint<TEntity>();
            var uri = $"{endpoint}/filters";

            //add includes
            return await GetApiRequest<TEntity>(uri, false);
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
