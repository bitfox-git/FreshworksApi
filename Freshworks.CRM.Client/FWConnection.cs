using Freshworks.CRM.Client.Models;
using Freshworks.CRM.Client.Selectors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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


        public async Task<List<Filter>> GetSalesAccountFilters()
        {
            var responseObject = await GetApiRequest<Filters>($"api/sales_accounts/filters");
            return responseObject.filters;
        }

        public async Task<ListResponse<SalesAccount>> GetSalesAccountsPage(long viewID, int page)
        {

            var responseObject = await GetApiRequest<ListResponse<SalesAccount>>($"api/sales_accounts/view/{viewID}?page={page}");

            return responseObject;
        }

        public async Task<List<SalesAccount>> GetSalesAccountsAll()
        {
            //first , request the correct filter
            var filters = await GetSalesAccountFilters();

            var viewId = filters
                           .Where(x => x.name.ToLower().StartsWith("all ") && x.is_default)
                           .Select(x => x.id)
                           .FirstOrDefault();

            var result = new List<SalesAccount>();

            int page = 1;

            while (page > 0)
            {
                var records = await GetSalesAccountsPage(viewId, page);
                result.AddRange(records.items);
                if (result.Count < records.meta.total)
                {
                    page++;
                }
                else
                {
                    page = -1;
                }
            }

            return result;

        }

        public async Task<SalesAccount> GetSalesAccountByID( long id)
        {
            var resp = await GetApiRequest<SingleRecordResponse<SalesAccount>>($"api/sales_accounts/{id}");
            return resp.item;
        }


        public async Task<Result<T>> Insert<T>(T value) where T : IUniqueID
        {
            var endpoint = EndpointNameAttribute.GetEndpointNameOfType<T>();
            if (endpoint == null) {
                return new Result<T>($"Type {nameof(T)} has no endpointname attribute." );
            }

            if (value.id != 0)
            {
                return new Result<T>($"Cannot insert record with existing id.");
            }

            var url = $"api/{endpoint}";

            var json = JsonConvert.SerializeObject(value);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{BaseURL}{url}"),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), $"Token token={apikey}" },


                },
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var resp = await client.SendAsync(request);
            //if (!resp.IsSuccessStatusCode)
            //{
            //    return new Result<T>() { ErrorMessage = $"{resp.StatusCode}" };
            //}

            var content = await resp.Content.ReadAsStringAsync();
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new CustomResolver()
            };

            var intermediateObject = JsonConvert.DeserializeObject<SingleRecordResponse<T>>(content, settings);
            if (intermediateObject.errors != null)
            {
                return new Result<T>(String.Join(",", intermediateObject.errors.message));
            }

            return new Result<T>(intermediateObject.item);
        }

        public async Task<T> Update<T>(T value) where T:IUniqueID
        {
            var endpoint = EndpointNameAttribute.GetEndpointNameOfType<T>();
            if (endpoint == null) { return default(T); }

            if (value.id == 0)
            {
                //cannot update a record with id =0 , you probably mean ot Create
                return default(T);
            }

            var url = $"api/{endpoint}/{value.id}";

            var json = JsonConvert.SerializeObject(value);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri($"{BaseURL}{url}"),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), $"Token token={apikey}" },
                    

                },
                Content = new StringContent(json, Encoding.UTF8, "application/json")
        };

            var resp = await client.SendAsync(request);
            if (!resp.IsSuccessStatusCode)
            {
                throw new Exception(resp.ReasonPhrase);
            }

            var content = await resp.Content.ReadAsStringAsync();

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new CustomResolver()
            };

            var intermediateObject =  JsonConvert.DeserializeObject<SingleRecordResponse<T>>(content, settings);
            return intermediateObject.item;
        }

        public async Task<T> GetSelectorsAsync<T>() where T : ISelector
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

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new CustomResolver()
            };
          
            return JsonConvert.DeserializeObject<T>(content,settings);



        }

    }
}
