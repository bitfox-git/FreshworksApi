using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.EndpointFilters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Network
    {
        protected readonly string BaseURL;
        protected readonly string ApiKey;
        private readonly HttpClient Client = new();

        public Network(string baseURL, string apikey)
        {
            BaseURL = baseURL;
            ApiKey = apikey;
        }

        // Get Http calls
        protected async Task<Result<TEntity>> GetApiRequest<TEntity>(string path)
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

            var resp = await Client.SendAsync(request);
            var content = await resp.Content.ReadAsStringAsync();
            return new Result<TEntity>(content);
        }

        // Post Http calls
        protected async Task<Result<TEntity>> PostApiRequest<TEntity>(string path, TEntity body)
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

            var resp = await Client.SendAsync(request);
            var content = await resp.Content.ReadAsStringAsync();
            return new Result<TEntity>(content);
        }

        protected async Task<Result<TEntity>> PostApiFormRequest<TEntity>(string path, Dictionary<string, string> files=null, Dictionary<string, string> parameters=null)
        {
            string url = BaseURL + path;
            RestClient client = new(url);

            #region Create Package
            
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", $"Token token={ ApiKey }");

            if (files != null)
            {
                foreach (var row in files)
                {
                    request.AddFile(row.Key, row.Value);
                }
            }
            
            if (parameters != null)
            {
                foreach (var row in parameters)
                {
                    request.AddParameter(row.Key, row.Value);
                }
            }

            IRestResponse response = await client.ExecuteAsync(request);

            #endregion

            var content = response.Content;
            return new Result<TEntity>(content);
        }

        // Put Http calls
        protected async Task<Result<TEntity>> UpdateApiRequest<TEntity>(string path, TEntity body)
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
                    { HttpRequestHeader.Authorization.ToString(), $"Token token={ApiKey}" }
                },
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var resp = await Client.SendAsync(request);
            var content = await resp.Content.ReadAsStringAsync();
            return new Result<TEntity>(content);
        }

        // Delete Http calls
        protected async Task<Result<TEntity>> DeleteApiRequest<TEntity>(string path)
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

            var resp = await Client.SendAsync(request);
            var content = await resp.Content.ReadAsStringAsync();
            return new Result<TEntity>(content);
        }

        protected async Task<Result<bool>> DeleteApiRequest(string path)
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

            var resp = await Client.SendAsync(request);
            var content = await resp.Content.ReadAsStringAsync();
            return new Result<bool>(content);
        }

        // Get endpoint
        protected static string GetEndpoint<TEntity>()
        {
            var endpoint = EndpointNameAttribute.GetEndpointNameOfType<TEntity>();
            if (endpoint == null)
            {
                throw new ArgumentException($"nameof(T) has no EndpointName Attribute defined.");
            }

            return endpoint;
        }

    }
}
