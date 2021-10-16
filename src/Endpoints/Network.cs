using Bitfox.Freshworks.Attributes;
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
        protected readonly string BaseURL;
        protected readonly string ApiKey;
        private readonly HttpClient Client = new();

        public Network(string baseURL, string apikey)
        {
            BaseURL = baseURL;
            ApiKey = apikey;
        }

        // Get Http calls
        protected async Task<Result<TEntity>> GetApiRequest<TEntity>(string path, bool hasIncludes=false)
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
            //JsonSerializerSettings settings = new()
            //{
            //    ContractResolver = new CustomResolver()
            //};

            return new Result<TEntity>(content, hasIncludes);
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
            //JsonSerializerSettings settings = new()
            //{
            //    ContractResolver = new CustomResolver()
            //};

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
            //JsonSerializerSettings settings = new()
            //{
            //    ContractResolver = new CustomResolver()
            //};

            return new Result<TEntity>(content);
        }

        // Delete Http calls
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
            //JsonSerializerSettings settings = new()
            //{
            //    ContractResolver = new CustomResolver()
            //};

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


        //// Get Http calls
        //protected async Task<TResponse> GetApiRequest<TResponse>(string path, bool hasIncludes) where TResponse : IIncludes
        //{
        //    string url = BaseURL + path;
        //    var request = new HttpRequestMessage
        //    {
        //        Method = HttpMethod.Get,
        //        RequestUri = new Uri(url),
        //        Headers = {
        //            { HttpRequestHeader.Authorization.ToString(), $"Token token={ApiKey}" }
        //        }
        //    };

        //    var result = await Client.SendAsync(request);
        //    var data = await result.Content.ReadAsStringAsync();
        //    return GetResponse<TResponse>(data, hasIncludes);
        //}

        //// Post Http calls
        //protected async Task<TResponse> PostApiRequest<TRequest, TResponse>(string path, TRequest body, bool hasIncludes) where TResponse : IIncludes
        //{
        //    string url = BaseURL + path;

        //    // create json & remove unused content
        //    var json = JsonConvert.SerializeObject(body, Formatting.None,
        //        new JsonSerializerSettings
        //        {
        //            NullValueHandling = NullValueHandling.Ignore
        //        }
        //    );

        //    var request = new HttpRequestMessage
        //    {
        //        Method = HttpMethod.Post,
        //        RequestUri = new Uri(url),
        //        Headers = {
        //            { HttpRequestHeader.Authorization.ToString(), $"Token token={ApiKey}" },
        //        },
        //        Content = new StringContent(json, Encoding.UTF8, "application/json")
        //    };

        //    var result = await Client.SendAsync(request);
        //    var data = await result.Content.ReadAsStringAsync();
        //    return GetResponse<TResponse>(data, hasIncludes);
        //}

        //// Put Http calls
        //protected async Task<TResponse> UpdateApiRequest<TRequest, TResponse>(string path, TRequest body, bool hasIncludes) where TResponse : IIncludes
        //{
        //    string url = BaseURL + path;
        //    JsonSerializerSettings serializesettings = new()
        //    {
        //        NullValueHandling = NullValueHandling.Ignore,
        //        DefaultValueHandling = DefaultValueHandling.Ignore
        //    };

        //    var json = JsonConvert.SerializeObject(body, serializesettings);
        //    var request = new HttpRequestMessage
        //    {
        //        Method = HttpMethod.Put,
        //        RequestUri = new Uri(url),
        //        Headers = {
        //            { HttpRequestHeader.Authorization.ToString(), $"Token token={ApiKey}" }
        //        },
        //        Content = new StringContent(json, Encoding.UTF8, "application/json")
        //    };

        //    var result = await Client.SendAsync(request);
        //    var data = await result.Content.ReadAsStringAsync();
        //    return GetResponse<TResponse>(data, hasIncludes);
        //}

        //// Delete Http calls
        //protected async Task<bool> DeleteApiRequest(string path)
        //{
        //    string url = BaseURL + path;
        //    var request = new HttpRequestMessage
        //    {
        //        Method = HttpMethod.Delete,
        //        RequestUri = new Uri(url),
        //        Headers = {
        //            { HttpRequestHeader.Authorization.ToString(), $"Token token={ApiKey}" }
        //        }
        //    };

        //    var result = await Client.SendAsync(request);
        //    return result.IsSuccessStatusCode;
        //}


        //protected async Task<TResponse> DeleteApiRequest<TResponse>(string path, bool hasIncludes) where TResponse : IIncludes
        //{
        //    string url = BaseURL + path;
        //    var request = new HttpRequestMessage
        //    {
        //        Method = HttpMethod.Delete,
        //        RequestUri = new Uri(url),
        //        Headers = {
        //            { HttpRequestHeader.Authorization.ToString(), $"Token token={ApiKey}" }
        //        }
        //    };

        //    var result = await Client.SendAsync(request);
        //    var data = await result.Content.ReadAsStringAsync();
        //    return GetResponse<TResponse>(data, hasIncludes);
        //}

        //protected async Task<bool> DeleteApiRequest<TResponse>(string path)
        //{
        //    string url = BaseURL + path;
        //    var request = new HttpRequestMessage
        //    {
        //        Method = HttpMethod.Delete,
        //        RequestUri = new Uri(url),
        //        Headers = {
        //            { HttpRequestHeader.Authorization.ToString(), $"Token token={ApiKey}" }
        //        }
        //    };

        //    var resp = await Client.SendAsync(request);
        //    var content = await resp.Content.ReadAsStringAsync();
        //    //JsonSerializerSettings settings = new()
        //    //{
        //    //    ContractResolver = new CustomResolver()
        //    //};

        //    return JsonConvert.DeserializeObject<bool>(content);
        //}

        //// Insert response model
        //private static TResponse GetResponse<TResponse> (string data, bool hasIncludes) where TResponse: IIncludes
        //{
        //    JObject json = (JObject)JsonConvert.DeserializeObject(data);
        //    TResponse response = json.ToObject<TResponse>();

        //    //// get includes from properties
        //    //if (hasIncludes)
        //    //{
        //    //    Includes includes = new();
        //    //    foreach (PropertyInfo prop in typeof(TResponse).GetProperties())
        //    //    {
        //    //        foreach (object attr in prop.GetCustomAttributes(true))
        //    //        {
        //    //            if (attr.GetType() != typeof(JsonPropertyAttribute)) continue;
        //    //            string name = (attr as JsonPropertyAttribute).PropertyName;

        //    //            if (json.ContainsKey(name) && json.SelectToken(name) is JObject)
        //    //            {
        //    //                var include = json[name].ToObject<Includes>();
        //    //                includes.Update(include);
        //    //                json.Remove(name);
        //    //            }
        //    //        }
        //    //    }

        //    //    // add includes to response
        //    //    includes.Update(json.ToObject<Includes>());
        //    //    if (!includes.IsEmpty())
        //    //    {
        //    //        response.Includes = includes;
        //    //    }
        //    //}

        //    return response;
        //}

    }
}
