
using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    /// <summary>
    /// Base Controller controls most used requests.
    /// </summary>
    /// <typeparam name="TRequest">Model used as payload in requests</typeparam>
    /// <typeparam name="TResponse">Model for all responses</typeparam>
    public class BaseController<TRequest, TResponse> : Network where TResponse : IIncludes
    {
        public BaseController(string baseURL, string apikey): base(baseURL, apikey)
        { }

        // Create item
        public async Task<TResponse> Create(TRequest payload, Params _params=null) 
        {
            string path = $"/";
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await PostApiRequest<TRequest, TResponse>(path, payload, hasIncludes);
        }

        // Get Items on content ID
        public async Task<TResponse> GetAllByID(long id, Params _params=null)
        {
            string path = $"/view/{id}";
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await GetApiRequest<TResponse>(path, hasIncludes);
        }

        // Get Item on ID
        public async Task<TResponse> GetByID(long id, Params _params=null)
        {
            string path = $"/{id}";
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await GetApiRequest<TResponse>(path, hasIncludes);
        }

        // Update Item on ID
        public async Task<TResponse> UpdateByID(long id, TRequest payload, Params _params=null)
        {
            string path = $"/{id}";
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await UpdateApiRequest<TRequest, TResponse>(path, payload, hasIncludes);
        }

        // Delete Item on ID
        public async Task<bool> DeleteByID(long id, Params _params=null)
        {
            string path = $"/{id}";
            path = _params == null ? path : _params.AddPath(path);

            return await DeleteApiRequest(path);
        }

        // Clone Item Defined with ID
        public async Task<TResponse> CloneByID(long id, TRequest body, Params _params=null)
        {
            string path = $"/{id}/clone";
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await PostApiRequest<TRequest, TResponse>(path, body, hasIncludes);
        }

        // Forget Item by giving ID
        public async Task<bool> ForgetByID(long id, Params _params=null)
        {
            string path = $"/{id}/forget";
            path = _params == null ? path : _params.AddPath(path);

            return await DeleteApiRequest(path);
        }

        // Create Bulk of item IDs
        public async Task<TResponse> CreateBulk(BulkAssign body, Params _params=null)
        {
            string path = $"/bulk_assign_owner";
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await PostApiRequest<BulkAssign, TResponse>(path, body, hasIncludes);
        }

        // Delete Bulk of item IDs
        public async Task<TResponse> DeleteBulk(BulkDelete body, Params _params=null)
        {
            string path = $"/bulk_destroy";
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await PostApiRequest<BulkDelete, TResponse>(path, body, hasIncludes);
        }

        // Get All Fields 
        public async Task<TResponse> GetAllFields(string path, Params _params=null)
        {
            path = _params == null ? path : _params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await GetApiRequest<TResponse>(path, hasIncludes);
        }

        // Get All Activities
        public async Task<TResponse> GetAllActivitiesByID(long id, Params _params = null)
        {
            string path = $"/{id}/activities.json";
            path = _params == null ? path :_params.AddPath(path);
            bool hasIncludes = _params != null && _params.Includes != null;

            return await GetApiRequest<TResponse>(path, hasIncludes);
        }

    }
}
