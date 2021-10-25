using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.EndpointFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Query: Network, IQuery
    {
        protected List<string> Includes = new();

        public Query(string BaseURL, string apikey) : base(BaseURL, apikey)
        { }

        public IQuery Include(string include)
        {
            Includes.Add(include);
            return this;
        }

        public async Task<Result<T>> GetByID<T>(T body) where T : IHasView, IHasUniqueID
        {
            return await GetByID<T>((long)body.ID);
        }

        public async Task<Result<T>> GetByID<T>(long? id) where T : IHasView
        {
            if(id == null)
            {
                throw new ArgumentException($"ID is missing in request");
            }

            var endpoint = GetEndpoint<T>();
            var uri = $"{endpoint}/{id}";
            uri = AddIncludes(uri);

            //add includes
            return await GetApiRequest<T>(uri);
        }

        public async Task<Result<T>> GetAllByID<T>(T body) where T : IHasAllView, IHasUniqueID
        {
            return await GetAllByID<T>((long)body.ID);
        }

        public async Task<Result<T>> GetAllByID<T>(long? id) where T : IHasAllView
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is missing in request");
            }

            var endpoint = GetEndpoint<T>();
            var uri = $"{endpoint}/view/{id}";
            uri = AddIncludes(uri);

            return await GetApiRequest<T>(uri);
        }

        public async Task<Result<T>> GetAllByFilter<T>(string filter) where T : IHasView
        {
            var endpoint = GetEndpoint<T>();
            var uri = $"{endpoint}?filter={filter}";
            uri = AddIncludes(uri);

            return await GetApiRequest<T>(uri);
        }

        public async Task<Result<T>> GetAllFileAndLinks<T>(T body) where T : IHasFileAndLinks
        {
            return await GetAllFileAndLinks<T>((long)body.ID);
        }

        public async Task<Result<T>> GetAllFileAndLinks<T>(long? id) where T : IHasFileAndLinks
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is missing in request");
            }

            var paths = GetEndpoint<T>().Split("\\");
            var uri = $"{paths[^1]}/{id}/document_associations";
            return await GetApiRequest<T>(uri);
        }

        public async Task<Result<T>> GetAllActivitiesByID<T>(T body) where T : IHasActivities, IHasUniqueID
        {
            return await GetAllActivitiesByID<T>((long)body.ID);
        }

        public async Task<Result<T>> GetAllActivitiesByID<T>(long? id) where T : IHasActivities
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is missing in request");
            }

            var endpoint = GetEndpoint<T>();
            var uri = $"{endpoint}/{id}/activities.json";
            uri = AddIncludes(uri);

            return await GetApiRequest<T>(uri);
        }

        public async Task<Result<T>> GetAllFields<T>() where T: IHasFields
        {
            var endpoint = GetEndpoint<T>();
            string lastName = endpoint.Split("/").Last();
            string uri = $"/api/settings/{lastName}/fields";
            uri = AddIncludes(uri);

            return await GetApiRequest<T>(uri);
        }

        public async Task<Result<Search>> SearchOnQuery(string query)
        {
            var endpoint = GetEndpoint<Search>();
            var uri = $"{endpoint}?q={query}";
            uri = AddIncludes(uri);

            return await GetApiRequest<Search>(uri);
        }

        public async Task<Result<SearchFilter>> SearchOnFilter<T>(SearchFilter body) where T : IHasFilteredSearch
        {
            string[] paths = GetEndpoint<T>().Split("/");
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

        private string AddIncludes(string uri)
        {
            if(Includes.Count > 0)
            {
                uri += uri.Contains("?") ? "&" : "?";
                uri += $"include={string.Join(",", Includes)}";
            }

            return uri;
        }





        // Selectors
        public async Task<Result<Selector>> GetSalesActivityTypes()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/sales_activity_types";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetSalesActivityEntityTypes()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/sales_activity_entity_types";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetSalesActivityOutcomes()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/sales_activity_outcomes";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetSalesActivityOutcomesByID(long id)
        {
            string endpoint = $"{GetEndpoint<Selector>()}/sales_activity_types/{id}/sales_activity_outcomes";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetDealProducts()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/deal_products";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetDealStages()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/deal_stages";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetDealTypes()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/deal_types";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetDealReasons()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/deal_reasons";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetDealPipelines()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/deal_pipelines";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetDealPipelinesByID(long id)
        {
            string endpoint = $"{GetEndpoint<Selector>()}/deal_pipelines/{id}/deal_stages";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetDealPaymentStatuses()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/deal_payment_statuses";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetTerritories()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/territories";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetCampaigns()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/campaigns";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetOwners()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/owners";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetCurrencies()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/currencies";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetContactStatuses()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/contact_statuses";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetBusinessTypes()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/business_types";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetLifecycleStages()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/lifecycle_stages";
            return await GetApiRequest<Selector>(endpoint);
        }

        public async Task<Result<Selector>> GetIndustryTypes()
        {
            string endpoint = $"{GetEndpoint<Selector>()}/industry_types";
            return await GetApiRequest<Selector>(endpoint);
        }


    }
}
