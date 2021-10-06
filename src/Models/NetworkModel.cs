using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class NetworkModel<TResponse>
    {
        protected readonly HttpClient Client = new();

        protected async Task<TResponse> GetApiRequest(string url, string apikey, bool getFirstItem = false)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), $"Token token={apikey}" }
                }
            };

            var result = await Client.SendAsync(request);
            var data = await result.Content.ReadAsStringAsync();
            JsonSerializerSettings settings = new()
            {
                ContractResolver = new CustomResolver()
            };

            // Get object from data
            if (getFirstItem)
            {
                JObject obj = JObject.Parse(data);
                string key = obj.Properties().Select(p => p.Name).ToList().First();
                return obj[key].ToObject<TResponse>();
            }
            else
            {
                return JsonConvert.DeserializeObject<TResponse>(data, settings);
            }
        }

        protected async Task<Result<TResponse>> PostApiRequest<TRequest>(string url, string apikey, TRequest body)
        {
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
                    { HttpRequestHeader.Authorization.ToString(), $"Token token={apikey}" },
                },
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var resp = await Client.SendAsync(request);
            var content = await resp.Content.ReadAsStringAsync();
            JsonSerializerSettings settings = new()
            {
                ContractResolver = new CustomResolver()
            };

            var response = JsonConvert.DeserializeObject<TResponse>(content, settings);
            return new Result<TResponse>(response);
        }

        protected async Task<TResponse> UpdateApiRequest<TRequest>(string url, string apikey, TRequest body)
        {
            var serializesettings = new JsonSerializerSettings();
            serializesettings.NullValueHandling = NullValueHandling.Ignore;
            serializesettings.DefaultValueHandling = DefaultValueHandling.Ignore;

            var json = JsonConvert.SerializeObject(body, serializesettings);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri(url),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), $"Token token={apikey}" },


                },
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var resp = await Client.SendAsync(request);
            //if (!resp.IsSuccessStatusCode)
            //{
            //    throw new Exception(resp.ReasonPhrase);
            //}

            var content = await resp.Content.ReadAsStringAsync();

            JsonSerializerSettings settings = new()
            {
                ContractResolver = new CustomResolver()
            };

            var response = JsonConvert.DeserializeObject<TResponse>(content, settings);
            return response;
        }

        protected async Task<bool> DeleteApiRequest(string url, string apikey)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(url),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), $"Token token={apikey}" }
                }
            };

            var result = await Client.SendAsync(request);
            return result.IsSuccessStatusCode;
        }

    }
}
