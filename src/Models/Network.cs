using Bitfox.Freshworks.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        protected async Task<Result<TEntity>> PostApiFormRequest<TEntity>(string path, TEntity body)
        {























            string url = BaseURL + path;



            MultipartFormDataContent form = new MultipartFormDataContent();


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



        public static async void GoPost()
        {
            //Dictionary<string, string> parameters = new();
            //parameters.Add("username", "benemanuel");
            //parameters.Add("FullName", "benjamin emanuel");
            //parameters.Add("Phone", "0800-0800000");
            //parameters.Add("CNIC", "1234");
            //parameters.Add("address", "an address");
            //parameters.Add("Email", "ben@benemanuel.net");
            //parameters.Add("dateofbirth", "14/05/1974");
            //parameters.Add("Gender", "Male");
            //parameters.Add("PaymentMethod", "Credit Card");
            //parameters.Add("Title", "Mr");
            //parameters.Add("PhramaList", "123");

            //HttpClient client = new();
            //client.DefaultRequestHeaders.Add("Authorization", "Token token=OOuMhjaasZwwkfzO__tZFQ");



            //HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri);
            //MultipartFormDataContent form = new MultipartFormDataContent();



            //// FORM
            //MultipartFormDataContent form = new();
            //HttpContent content = new StringContent("file");
            //form.Add(content, "file");


            ////HttpContent DictionaryItems = new FormUrlEncodedContent(parameters);

            ////form.Add(DictionaryItems, "medicineOrder");

            //var stream = new FileStream("C:\\Users\n.tuytel\\OneDrive - Lucrasoft ICT Groep\\Afbeeldingen\\IMG-20210819-WA0004.jpg", FileMode.Open);
            //content = new StreamContent(stream);
            //content.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            //{
            //    Name = "file",
            //    FileName = "IMG-20210819-WA0004.jpg"
            //};
            //form.Add(content);

            //HttpResponseMessage response = null;

            //try
            //{
            //    response = (client.PostAsync("https://notdetected-team.myfreshworks.com/crm/sales/api/documents", form)).Result;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //var k = response.Content.ReadAsStringAsync().Result;
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
