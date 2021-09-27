using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    public class Query<TEntity> where TEntity : IHasView
    {

        private readonly ICRMClient client;
        private long viewID;

        private List<string> includes = new List<string>(); 

        public Query(ICRMClient client)
        {
            this.client = client;
        }

        public Query<TEntity> SetViewByID(long viewID)
        {
            this.viewID = viewID;
            return this;
        }

        public Query<TEntity> Include(string include)
        {
            includes.Add(include);
            return this;
        }


        public async Task<ListResponse<TEntity>> GetPage(long viewID, int page) 
        {
            var endpoint = GetEndpoint();
            var uri = $"api/{endpoint}/view/{viewID}?page={page}";

            //add includes
            uri += includes.Count > 0 ? $"&include={string.Join(",", includes)}" : "";

           

            var responseObject = await client.GetApiRequest<ListResponse<TEntity>>(uri);

            return responseObject;
        }

        

        public async Task<List<TEntity>> GetAll()
        {
          
            if (this.viewID == 0) { this.viewID = await getDefaultViewID(); }
            var result = new List<TEntity>();

            int page = 1;
            while (page > 0)
            {
                var records = await GetPage(this.viewID, page);
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

        public async Task<TEntity> GetByID(long id)
        {
            var endpoint = GetEndpoint();
            var uri = $"api/{endpoint}/{id}";

            //add includes
            uri += includes.Count > 0 ? $"&include={string.Join(",", includes)}" : "";


            var resp = await client.GetApiRequest<SingleRecordResponse<TEntity>>(uri);
            return resp.item;
        }


        public async Task<List<View>> GetViews() 
        {
            var endpoint = GetEndpoint();
            var responseObject = await client.GetApiRequest<Views>($"api/{endpoint}/filters");
            return responseObject.views;
        }

        private async Task<long> getDefaultViewID()
        {
            //first , request the correct filter
            var filters = await GetViews();

            //This is kind of a hack ? it looks for the "all ....." view for this entity...
            //is this 100% sure?
            var viewId = filters
                           .Where(x => x.name.ToLower().StartsWith("all ") && x.is_default)
                           .Select(x => x.id)
                           .FirstOrDefault();

            return viewId;
        }

        private string GetEndpoint() 
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
