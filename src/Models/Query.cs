using Bitfox.Freshworks.Endpoints.Selector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Query: BaseController, ISelectorController
    {
        private List<string> includes = new();

        public Query(string BaseURL, string apikey) : base(BaseURL, apikey)
        { }

        public Query Include(string include)
        {
            includes.Add(include);
            return this;
        }

        public async Task<Result<TEntity>> GetByID<TEntity>(TEntity body) where TEntity : IHasView, IHasUniqueID
        {
            return await GetByID<TEntity>((long)body.ID);
        }

        public async Task<Result<TEntity>> GetByID<TEntity>(long? id) where TEntity : IHasView
        {
            if(id == null)
            {
                throw new ArgumentException($"ID is missing in request");
            }

            var endpoint = GetEndpoint<TEntity>();
            var uri = $"{endpoint}/{id}";

            //add includes
            uri += includes.Count > 0 ? $"?include={string.Join(",", includes)}" : "";
            return await GetApiRequest<TEntity>(uri, (includes.Count > 0));
        }

        public async Task<Result<TEntity>> GetAllByID<TEntity>(TEntity body) where TEntity : IHasView, IHasUniqueID
        {
            return await GetAllByID<TEntity>((long)body.ID);
        }

        public async Task<Result<TEntity>> GetAllByID<TEntity>(long? id) where TEntity : IHasView
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is missing in request");
            }

            var endpoint = GetEndpoint<TEntity>();
            var uri = $"{endpoint}/view/{id}";

            //add includes
            uri += includes.Count > 0 ? $"&include={string.Join(",", includes)}" : "";
            return await GetApiRequest<TEntity>(uri, (includes.Count > 0));
        }

        public async Task<Result<TEntity>> GetAllActivitiesByID<TEntity>(TEntity body) where TEntity : IHasActivities, IHasUniqueID
        {
            return await GetAllActivitiesByID<TEntity>((long)body.ID);
        }

        public async Task<Result<TEntity>> GetAllActivitiesByID<TEntity>(long? id) where TEntity : IHasActivities
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is missing in request");
            }

            var endpoint = GetEndpoint<TEntity>();
            var uri = $"{endpoint}/{id}/activities.json";

            //add includes
            uri += includes.Count > 0 ? $"&include={string.Join(",", includes)}" : "";
            return await GetApiRequest<TEntity>(uri, (includes.Count > 0));
        }

        public async Task<Result<TEntity>> GetAllFields<TEntity>() where TEntity: IHasFields
        {
            var endpoint = GetEndpoint<TEntity>();
            string lastName = endpoint.Split("/").Last();
            string url = $"/api/settings/{lastName}/fields";

            //add includes
            url += includes.Count > 0 ? $"&include={string.Join(",", includes)}" : "";
            return await GetApiRequest<TEntity>(url, (includes.Count > 0));
        }

    }
}
