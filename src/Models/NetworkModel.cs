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
    public class NetworkModel
    {
        protected readonly HttpClient Client = new();

        public async Task<T> GetApiRequest<T>(string url, string apikey, bool getFirstItem = false)
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
                return obj[key].ToObject<T>();
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(data, settings);
            }
        }

        public async Task<Result<Dictionary<string, T>>> PostApiRequest<T>(string url, string apikey, T body, string bodyName) where T: IUniqueID
        {
            Dictionary<string, T> bodyReq = new();
            bodyReq.Add(bodyName, body);

            JsonSerializerSettings settings = new()
            {
                ContractResolver = new CustomResolver()
            };

            // create json & remove unused content
            var json = JsonConvert.SerializeObject(bodyReq, Formatting.None,
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
            var response = JsonConvert.DeserializeObject<Dictionary<string, T>>(content, settings);
            return new Result<Dictionary<string, T>>(response);
        }


    }
}
