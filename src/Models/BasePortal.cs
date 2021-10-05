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
    public class BasePortal<T>: NetworkModel
    {
        protected readonly string BaseURL;
        protected readonly string ApiKey;

        public BasePortal(string baseURL, string apikey)
        {
            BaseURL = baseURL;
            ApiKey = apikey;
        }

        public async Task<Result<Dictionary<string, T>>> Create<T>(T body) where T : IUniqueID, IHasView
        {
            var url = $"{BaseURL}/";
            return await PostApiRequest<T>(url, ApiKey, body, "contact");
        }

        public async Task<T> GetAll(long viewID)
        {
            var url = $"{BaseURL}/view/{viewID}";
            return await GetApiRequest<T>(url, ApiKey, getFirstItem: true);
        }

        //public T GetOnID(long id)
        //{
        //    return null;
        //}

        //public T UpdateOnID(long id, T content)
        //{
        //    return null;
        //}

        //public T DeleteOnID(long id)
        //{
        //    return null;
        //}
    }
}
