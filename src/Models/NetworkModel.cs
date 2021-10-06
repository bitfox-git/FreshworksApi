using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class NetworkModel
    {
        private readonly string BaseURL;
        private readonly string ApiKey;
        private readonly HttpClient Client = new();

        public NetworkModel(string baseURL, string apikey)
        {
            BaseURL = baseURL;
            ApiKey = apikey;
        }

        // Get Http calls
        protected async Task<TResponse> GetApiRequest<TResponse>(string path)
        {
            string url = BaseURL + path;
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), $"Token token={ApiKey}" }
                }
            };

            var result = await Client.SendAsync(request);
            var data = await result.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<TResponse>(
                data, 
                settings: new JsonSerializerSettings()
                {
                    ContractResolver = new CustomResolver()
                }
            );

            // valid response 
            return response;
        }

        // Post Http calls
        protected async Task<TResponse> PostApiRequest<TRequest, TResponse>(string path, TRequest body)
        {
            string url = BaseURL + path;

            // create json & remove unused content
            var json = JsonConvert.SerializeObject(body, Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                }
            );

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(url),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), $"Token token={ApiKey}" },
                },
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var result = await Client.SendAsync(request);
            var data = await result.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<TResponse>(
                data,
                settings: new JsonSerializerSettings()
                {
                    ContractResolver = new CustomResolver()
                }
            );

            // valid response 
            return response;
        }

        // Put Http calls
        protected async Task<TResponse> UpdateApiRequest<TRequest, TResponse>(string path, TRequest body)
        {
            string url = BaseURL + path;
            JsonSerializerSettings serializesettings = new()
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore
            };

            var json = JsonConvert.SerializeObject(body, serializesettings);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri(url),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), $"Token token={ApiKey}" },


                },
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var result = await Client.SendAsync(request);
            var data = await result.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<TResponse>(
                data,
                settings: new JsonSerializerSettings()
                {
                    ContractResolver = new CustomResolver()
                }
            );

            // valid response 
            return response;
        }

        // Delete Http calls
        protected async Task<bool> DeleteApiRequest(string path)
        {
            string url = BaseURL + path;
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(url),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), $"Token token={ApiKey}" }
                }
            };

            var result = await Client.SendAsync(request);
            return result.IsSuccessStatusCode;
        }
    
    }
}
