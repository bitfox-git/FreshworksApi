using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Freshworks.CRM.Client
{
    class FWConnection
    {

        private static HttpClient client = new HttpClient();

        private string subdomain;
        private string apikey;


        public FWConnection(string subdomain, string apikey)
        {
            this.subdomain = subdomain;
            this.apikey = apikey;
        }


        public List<T> GetSelectorAsync<T>()
        {

        }
        

        private GetApiRequets(string api, string optinos)
        {

            
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{baseUrl}/token"),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), $"Basic {base64credentials}" }

                }
            };


            var result = await client.SendAsync(httpRequestMessage);
            var content = await result.Content.ReadAsStringAsync();
            var x = JsonConvert.DeserializeObject<TokenResult>(content);
            return x.token;


            var requets = client.GetAsync()

        }

    }
}
