﻿using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.Selectors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    public class CRMClient : ICRMClient
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


        internal CRMClient(string subdomain, string apikey)
        {
            this.subdomain = subdomain;
            this.apikey = apikey;
        }


        public Query<T> Query<T>() where T:IHasView {
            return new Query<T>(this);
        }




        public async Task<Result<T>> Insert<T>(T value) where T : IUniqueID
        {
            var endpoint = GetEndpoint<T>();

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


            var serializesettings = new JsonSerializerSettings();
            serializesettings.NullValueHandling = NullValueHandling.Ignore;
            serializesettings.DefaultValueHandling = DefaultValueHandling.Ignore;

            var json = JsonConvert.SerializeObject(value, serializesettings);

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


        private string GetIncludeRequestParams<T>()
        {
            return "";
        }


        public async Task<T> GetApiRequest<T>(string url)
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

        private string GetEndpoint<TEntity>()
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
