﻿using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    /// <summary>
    /// Base Controller controls most used requests.
    /// </summary>
    /// <typeparam name="TRequest">Model used as payload in requests</typeparam>
    /// <typeparam name="TResponse">Model for all responses</typeparam>
    public class BaseController<TRequest, TResponse> : NetworkModel
    {
        public BaseController(string baseURL, string apikey): base(baseURL, apikey)
        { }

        // Create item
        public async Task<TResponse> Create(TRequest payload) 
        {
            var path = $"/";
            return await PostApiRequest<TRequest, TResponse>(path, payload);
        }

        // Get Items on content ID
        public async Task<TResponse> GetAllByID(long id)
        {
            var path = $"/view/{id}";
            return await GetApiRequest<TResponse>(path);
        }

        // Get Item on ID
        public async Task<TResponse> GetByID(long id)
        {
            var path = $"/{id}";
            return await GetApiRequest<TResponse>(path);
        }

        // Update Item on ID
        public async Task<TResponse> UpdateByID(long id, TRequest payload)
        {
            var path = $"/{id}";
            return await UpdateApiRequest<TRequest, TResponse>(path, payload);
        }

        // Delete Item on ID
        public async Task<bool> DeleteByID(long id)
        {
            var path = $"/{id}";
            return await DeleteApiRequest(path);
        }

        // Clone Item Defined with ID
        public async Task<TResponse> CloneByID(long id, TRequest body, string include = null, int? page = null)
        {
            var path = SetParams($"/{id}/clone", include, page);
            return await PostApiRequest<TRequest, TResponse>(path, body);
        }

        // Forget Item by giving ID
        public async Task<bool> ForgetByID(long id, string include = null, int? page = null)
        {
            var path = SetParams($"/{id}/forget", include, page);
            return await DeleteApiRequest(path);
        }

        // Create Bulk of item IDs
        public async Task<TResponse> CreateBulk(BulkAssignObject body, string include = null, int? page = null)
        {
            var path = SetParams($"/bulk_assign_owner", include, page);
            return await PostApiRequest<BulkAssignObject, TResponse>(path, body);
        }

        // Delete Bulk of item IDs
        public async Task<TResponse> DeleteBulk(BulkDeleteObject body, string include = null, int? page = null)
        {
            var path = SetParams($"/bulk_destroy", include, page);
            return await PostApiRequest<BulkDeleteObject, TResponse>(path, body);
        }

        // Get All Fields 
        public async Task<TResponse> GetAllFields(string path, string include = null, int? page = null)
        {
            path = SetParams(path, include, page);
            return await GetApiRequest<TResponse>(path);
        }

        // Get All Activities
        public async Task<TResponse> GetAllActivitiesByID(long id, string include = null, int? page = null)
        {
            var path = SetParams($"/{id}/activities.json", include, page);
            return await GetApiRequest<TResponse>(path);
        }

    }
}
