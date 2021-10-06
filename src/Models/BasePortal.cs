using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class BasePortal<TResponse>: NetworkModel<TResponse>
    {
        protected readonly string BaseURL;
        protected readonly string ApiKey;

        public BasePortal(string baseURL, string apikey)
        {
            BaseURL = baseURL;
            ApiKey = apikey;
        }

        public async Task<Result<TResponse>> Create<TRequest>(TRequest body)
        {
            var url = $"{BaseURL}/";
            return await PostApiRequest(url, ApiKey, body);
        }

        public async Task<TResponse> GetAll(long viewID)
        {
            var url = $"{BaseURL}/view/{viewID}";
            return await GetApiRequest(url, ApiKey);
        }

        public async Task<TResponse> GetOnID(long contactID)
        {
            var url = $"{BaseURL}/{contactID}";
            return await GetApiRequest(url, ApiKey);
        }

        public async Task<TResponse> UpdateOnID<TRequest>(long contactID, TRequest body)
        {
            var url = $"{BaseURL}/{contactID}";
            return await UpdateApiRequest(url, ApiKey, body);
        }

        public async Task<bool> DeleteOnID(long contactID)
        {
            var url = $"{BaseURL}/{contactID}";
            return await DeleteApiRequest(url, ApiKey);
        }
    }
}
