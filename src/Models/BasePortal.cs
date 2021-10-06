using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class BasePortal<TCreateRequest, TUpdateOnIDRequest, TResponse> : NetworkModel
    {
        public BasePortal(string baseURL, string apikey): base(baseURL, apikey)
        { }

        // Base Panel Create
        public async Task<TResponse> Create(TCreateRequest payload) 
        {
            var path = $"/";
            return await PostApiRequest<TCreateRequest, TResponse>(path, payload);
        }

        // Base Panel Get All
        public async Task<TResponse> GetAllByID(long id)
        {
            var path = $"/view/{id}";
            return await GetApiRequest<TResponse>(path);
        }

        // Base Panel Get On ID
        public async Task<TResponse> GetByID(long id)
        {
            var path = $"/{id}";
            return await GetApiRequest<TResponse>(path);
        }

        // Base Panel Update On ID
        public async Task<TResponse> UpdateByID(long id, TUpdateOnIDRequest payload)
        {
            var path = $"/{id}";
            return await UpdateApiRequest<TUpdateOnIDRequest, TResponse>(path, payload);
        }

        // Base Panel Delete On ID
        public async Task<bool> DeleteByID(long id)
        {
            var path = $"/{id}";
            return await DeleteApiRequest(path);
        }

        // Set Include and Page params to request 
        protected string SetParams(string path, string include = null, int? page = null)
        {
            if (include != null || page != null)
            {
                path += "?";
            }

            if (page != null)
            {
                path += $"page={page}";
            }

            if (include != null)
            {
                path += $"include={include}";
            }

            return path;
        }
    }
}
