using Freshworks.CRM.Client.Selectors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Freshworks.CRM.Client
{
    public class FWConnection : IFWConnection
    {

        private static HttpClient client = new HttpClient();

        private string subdomain;
        private string apikey;


        public string BaseURL
        {
            get
            {
                return $"https://{subdomain}.myfreshworks.com/crm/sales/";
            }
        }


        public FWConnection(string subdomain, string apikey)
        {
            this.subdomain = subdomain;
            this.apikey = apikey;
        }


        public async Task<TReturn> GetSelectorsAsync<T>() where T : ISelector<TReturn>
        {

            var endpoint = EndpointNameAttribute.GetEndpointNameOfType<T>();

            if (endpoint == null) { return default(T); }

            return await GetApiRequest<T>($"api/selector/{endpoint}");
        }
        

        private async Task<T> GetApiRequest<T>(string url)
        {

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{BaseURL}{url}"),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), $"Token token={apikey}" }

                }
            };


            var result = await client.SendAsync(request);
            var content = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);



        }

    }
}
