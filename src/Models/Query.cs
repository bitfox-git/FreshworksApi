using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Query: Network
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

        public async Task<Result<TEntity>> GetAllFields<TEntity>() where TEntity: IHasFields
        {
            var uri = $"/api/settings/sales_accounts/fields";

            //add includes
            uri += includes.Count > 0 ? $"&include={string.Join(",", includes)}" : "";
            return await GetApiRequest<TEntity>(uri, (includes.Count > 0));
        }

        // TESTs




        //public async Task<Result<TEntity>> GetPage(long viewID, int page)
        //{
        //    var endpoint = GetEndpoint<TEntity>();
        //    var uri = $"{endpoint}/view/{viewID}?page={page}";

        //    //add includes
        //    uri += includes.Count > 0 ? $"&include={string.Join(",", includes)}" : "";
        //    return await GetApiRequest<TEntity>(uri);
        //}




        //public async Task<List<TEntity>> GetAll()
        //{

        //    if (this.viewID == 0) { this.viewID = await getDefaultViewID(); }
        //    var result = new List<TEntity>();

        //    int page = 1;
        //    while (page > 0)
        //    {
        //        var records = await GetPage(this.viewID, page);
        //        result.AddRange(records.items);
        //        if (result.Count < records.meta.total)
        //        {
        //            page++;
        //        }
        //        else
        //        {
        //            page = -1;
        //        }
        //    }

        //    return result;

        //}

        //public async Task<TEntity> GetByID(long id)
        //{
        //    var endpoint = GetEndpoint<TEntity>();
        //    var uri = $"{endpoint}/{id}";

        //    //add includes
        //    uri += includes.Count > 0 ? $"&include={string.Join(",", includes)}" : "";
        //    return await GetApiRequest<TEntity>(uri);
        //}

        //public async Task<List<TEntity>> GetViews<TEntity>()
        //{
        //    var endpoint = GetEndpoint<TEntity>();
        //    return await GetApiRequest<List<TEntity>>($"{endpoint}/filters");
        //}

        //private async Task<long> getDefaultViewID<TEntity>()
        //{
        //    //first , request the correct filter
        //    var filters = await GetViews<TEntity>();

        //    //This is kind of a hack ? it looks for the "all ....." view for this entity...
        //    //is this 100% sure?
        //    var viewId = filters
        //                   .Where(x => x.name.ToLower().StartsWith("all ") && x.is_default)
        //                   .Select(x => x.id)
        //                   .FirstOrDefault();

        //    return viewId;
        //}

        //public TEntity GetByID(long id)
        //{
        //    return (TEntity)(object) null;
        //}

        //public TEntity GetAllByID(long id)
        //{
        //    return (TEntity)(object)null;
        //}

        //public TEntity GetAllFieldsByID(long id)
        //{
        //    return (TEntity)(object)null;
        //}

        ///// <summary>
        ///// Amount of pages as limit (1 page is 25 items)
        ///// </summary>
        //public string Filter { get; set; } = null;


        ///// <summary>
        ///// Amount of pages as limit (1 page is 25 items)
        ///// </summary>
        //public int? Page { get; set; } = null;

        ///// <summary>
        ///// Limit Amount response containing 
        ///// </summary>
        //public int? Limit { get; set; } = null;


        //public TEntity GetAllActivitiesByID(long id)
        //{
        //    return (TEntity)(object)null;
        //}

        //GetAllFields(string path, Params _params = null)
        //{
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await GetApiRequest<TResponse>(path, hasIncludes);
        //}

        //// Get All Activities
        //public async Task<TResponse> GetAllActivitiesByID(

    }
}
