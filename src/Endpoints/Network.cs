using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Network
    {
        private readonly string BaseURL;
        private readonly string ApiKey;
        private readonly HttpClient Client = new();

        public Network(string baseURL, string apikey)
        {
            BaseURL = baseURL;
            ApiKey = apikey;
        }

        // Get Http calls
        protected async Task<TResponse> GetApiRequest<TResponse>(string path) where TResponse: IIncludes
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
            return GetResponse<TResponse>(data);
        }

        // Post Http calls
        protected async Task<TResponse> PostApiRequest<TRequest, TResponse>(string path, TRequest body) where TResponse : IIncludes
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
            return GetResponse<TResponse>(data);
        }

        // Put Http calls
        protected async Task<TResponse> UpdateApiRequest<TRequest, TResponse>(string path, TRequest body) where TResponse : IIncludes
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

            var result = await Client.SendAsync(request);
            var data = await result.Content.ReadAsStringAsync();
            return GetResponse<TResponse>(data);
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

        // Delete Http calls
        protected async Task<TResponse> DeleteApiRequest<TResponse>(string path) where TResponse : IIncludes
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
            return GetResponse<TResponse>(data);
        }

        // Create response model
        private static TResponse GetResponse<TResponse> (string data) where TResponse: IIncludes
        {
            JObject json = (JObject)JsonConvert.DeserializeObject(data);
            TResponse response = json.ToObject<TResponse>();
            Includes includes = new();

            // get includes from properties
            foreach (PropertyInfo prop in typeof(TResponse).GetProperties())
            {
                foreach (object attr in prop.GetCustomAttributes(true))
                {
                    if (attr.GetType() != typeof(JsonPropertyAttribute)) continue;
                    string name = (attr as JsonPropertyAttribute).PropertyName;

                    if (json.ContainsKey(name) && json.SelectToken(name) is JObject)
                    {
                        var include = json[name].ToObject<Includes>();
                        includes.Update(include);
                        json.Remove(name);
                    }
                }
            }

            // add includes to response
            includes.Update(json.ToObject<Includes>());
            if (!includes.HasNull())
            {
                response.Includes = includes;
            }

            return response;
        }
    }
}
