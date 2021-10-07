using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
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

        /// <summary>
        /// HTTP request, that uses POST to create new content.
        /// </summary>
        /// <typeparam name="TRequest">Payload object that will been used for creating content</typeparam>
        /// <typeparam name="TResponse">Response object from the request</typeparam>
        /// <param name="path">Url Path</param>
        /// <param name="body">New payload that will used for new content</param>
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

        /// <summary>
        /// HTTP request, that uses PUT to update some content.
        /// </summary>
        /// <typeparam name="TRequest">Payload object that will been used for updating</typeparam>
        /// <typeparam name="TResponse">Response object from the request</typeparam>
        /// <param name="path">Url Path</param>
        /// <param name="body">New payload that will update the old content</param>
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

        /// <summary>
        /// HTTP request, that uses DELETE to remove some content.
        /// </summary>
        /// <param name="path">Url Path</param>
        /// <returns> boolean `true` if succeeded</returns>
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

        /// <summary>
        /// HTTP request, that uses DELETE to remove some content.
        /// </summary>
        /// <typeparam name="TResponse">Type of response model</typeparam>
        /// <param name="path">Url path</param>
        protected async Task<TResponse> DeleteApiRequest<TResponse>(string path)
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

        /// <summary>
        /// Set `include` or `page` param to the URL path.
        /// </summary>
        /// <param name="path">Url path</param>
        /// <param name="include">Include objects to the original response object</param>
        /// <param name="page">1 page contains 25 items, by using `page` we can limit response results</param>
        protected static string SetParams(string path, string include = null, int? page = null)
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
