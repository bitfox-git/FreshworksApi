using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    public class CRMClient : Network, 
        ICRMClient,
        ISearch,
        IContact,
        IAccount,
        IDeal,
        INote,
        ITask,
        IAppointment,
        ISale,
        IPhone
    {
        private readonly List<string> Includes = new();

        public ISelector Selector => Query();

        public ISearch Search => this;

        public IContact Contact => this;

        public IAccount Account => this;

        public IDeal Deal => this;

        public INote Note => this;

        public ITask Task => this;

        public IAppointment Appointment => this;

        public ISale Sale => this;

        public IPhone Phone => this;

        internal CRMClient(string subdomain, string apikey): base($"https://{subdomain}.myfreshworks.com/crm/sales", apikey)
        { }

        public IQuery Include(string include)
        {
            Includes.Add(include);
            return Query();
        }

        public IQuery Query()
        {
            return new Query(BaseURL, ApiKey, Includes);
        }

        public async Task<Result<TEntity>> FetchAll<TEntity>() where TEntity : IHasFilters
        {
            string endpoint = $"{GetEndpoint<TEntity>()}/filters";
            return await GetApiRequest<TEntity>(endpoint);
        }

        public async Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert
        {
            body.CatchInsertExceptions();
            string endpoint = GetEndpoint<TEntity>();
            return await PostApiRequest(endpoint, body);
        }

        public async Task<Result<TEntity>> Update<TEntity>(TEntity body) where TEntity : IHasUpdate
        {
            body.CatchUpdateExceptions();
            string endpoint = $"{GetEndpoint<TEntity>()}/{body.ID}";
            return await UpdateApiRequest(endpoint, body);
        }

        public async Task<Result<TEntity>> Clone<TEntity>(TEntity body) where TEntity : IHasClone
        {
            body.CatchCloneExceptions();
            string endpoint = $"{GetEndpoint<TEntity>()}/{body.ID}/clone";
            return await PostApiRequest(endpoint, body);
        }

        public async Task<Result<bool>> Delete<TEntity>(long? id) where TEntity : IHasDelete
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is required for removing the view.");
            }

            string endpoint = $"{GetEndpoint<TEntity>()}/{id}";
            return await DeleteApiRequest(endpoint);
        }

        public async Task<Result<bool>> Delete<TEntity>(TEntity body) where TEntity : IHasDelete
        {
            body.CatchDeleteExceptions();
            string endpoint = $"{GetEndpoint<TEntity>()}/{body.ID}";
            return await DeleteApiRequest(endpoint);
        }

        public async Task<Result<TEntity>> Delete<TEntity>(TEntity body, bool hasBodyAsResponse) where TEntity : IHasDelete
        {
            body.CatchDeleteExceptions();
            string endpoint = $"{GetEndpoint<TEntity>()}/{body.ID}";
            return await DeleteApiRequest<TEntity>(endpoint);
        }

        public async Task<Result<bool>> Forget<TEntity>(long? id) where TEntity : IHasForget
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is required for removing the view.");
            }

            string endpoint = $"{GetEndpoint<TEntity>()}/{id}/forget";
            return await DeleteApiRequest(endpoint);
        }

        public async Task<Result<bool>> Forget<TEntity>(TEntity body) where TEntity : IHasForget
        {
            body.CatchForgetExceptions();
            string endpoint = $"{GetEndpoint<TEntity>()}/{body.ID}/forget";
            return await DeleteApiRequest(endpoint);
        }

        public async Task<Result<TEntity>> AssignBulk<TEntity>(TEntity body) where TEntity : IHasAssignBulk
        {
            body.CatchAssignBulkExceptions();
            string endpoint = $"{GetEndpoint<TEntity>()}/bulk_assign_owner";
            return await PostApiRequest(endpoint, body);
        }

        public async Task<Result<TEntity>> DeleteBulk<TEntity>(TEntity body) where TEntity : IHasDeleteBulk
        {
            body.CatchDeleteBulkExceptions();
            string endpoint = $"{GetEndpoint<TEntity>()}/bulk_destroy";
            return await PostApiRequest(endpoint, body);
        }

        public async Task<Result<Search>> SearchOnQuery(string query)
        {
            var endpoint = GetEndpoint<Search>();
            var uri = $"{endpoint}?q={query}";
            //uri = AddIncludes(uri);

            return await GetApiRequest<Search>(uri);
        }

        public async Task<Result<SearchFilter>> SearchOnFilter<TEntity>(SearchFilter body) where TEntity: IHasFilteredSearch
        {
            string[] paths = GetEndpoint<TEntity>().Split("/");
            string target = paths[^1];
            if (target.EndsWith("s"))
            {
                target = target[0..^1];
            }

            string endpoint = $"{GetEndpoint<SearchFilter>()}/{target}";
            return await PostApiRequest(endpoint, body);
        }

        public async Task<Result<SearchLookup>> SearchOnLookup(string query, string field, string entities)
        {
            string endpoint = $"{GetEndpoint<SearchLookup>()}?q={query}&f={field}&entities={entities}";
            return await GetApiRequest<SearchLookup>(endpoint);
        }

    }
}
