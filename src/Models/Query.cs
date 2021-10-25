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

        private string AddIncludes(string uri)
        {
            if(Includes.Count > 0)
            {
                uri += uri.Contains("?") ? "&" : "?";
                uri += $"include={string.Join(",", Includes)}";
            }

            return uri;
        }

        public async Task<Result<T>> GetByID<T>(T body) where T : IHasView, IHasUniqueID
            => await GetByID<T>((long)body.ID);

        public async Task<Result<T>> GetByID<T>(long? id) where T : IHasView
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is missing in request");
            }
            var uri = AddIncludes($"{GetEndpoint<T>()}/{id}");

            //add includes
            return await GetApiRequest<T>(uri);
        }

        public async Task<Result<T>> GetAllByID<T>(T body) where T : IHasAllView, IHasUniqueID
            => await GetAllByID<T>((long)body.ID);

        public async Task<Result<T>> GetAllByID<T>(long? id) where T : IHasAllView
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is missing in request");
            }

            var uri = AddIncludes($"{GetEndpoint<T>()}/view/{id}");
            return await GetApiRequest<T>(uri);
        }

        public async Task<Result<T>> GetAllByFilter<T>(string filter) where T : IHasView
        {
            var uri = AddIncludes($"{GetEndpoint<T>()}?filter={filter}");
            return await GetApiRequest<T>(uri);
        }

        public async Task<Result<T>> GetAllFileAndLinks<T>(T body) where T : IHasFileAndLinks
            => await GetAllFileAndLinks<T>((long)body.ID);

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
            => await GetAllActivitiesByID<T>((long)body.ID);

        public async Task<Result<T>> GetAllActivitiesByID<T>(long? id) where T : IHasActivities
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is missing in request");
            }

            var uri = AddIncludes($"{GetEndpoint<T>()}/{id}/activities.json");
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
            var uri = AddIncludes($"{GetEndpoint<Search>()}?q={query}");
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
            => await GetEndpoint<SearchLookup>($"?q={query}&f={field}&entities={entities}");

        // Selectors
        public async Task<Result<Selector>> GetSalesActivityTypes() 
            => await GetEndpoint<Selector>("/sales_activity_types");

        public async Task<Result<Selector>> GetSalesActivityEntityTypes() 
            => await GetEndpoint<Selector>("/sales_activity_entity_types");

        public async Task<Result<Selector>> GetSalesActivityOutcomes() 
            => await GetEndpoint<Selector>("/sales_activity_outcomes");

        public async Task<Result<Selector>> GetSalesActivityOutcomesByID(long id) 
            => await GetEndpoint<Selector>("/sales_activity_types/{id}/sales_activity_outcomes");

        public async Task<Result<Selector>> GetDealProducts() 
            => await GetEndpoint<Selector>("/deal_products");

        public async Task<Result<Selector>> GetDealStages() 
            => await GetEndpoint<Selector>("/deal_stages");

        public async Task<Result<Selector>> GetDealTypes() 
            => await GetEndpoint<Selector>("/deal_types");

        public async Task<Result<Selector>> GetDealReasons() 
            => await GetEndpoint<Selector>("/deal_reasons");

        public async Task<Result<Selector>> GetDealPipelines() 
            => await GetEndpoint<Selector>("/deal_pipelines");

        public async Task<Result<Selector>> GetDealPipelinesByID(long id) 
            => await GetEndpoint<Selector>($"/deal_pipelines/{id}/deal_stages");

        public async Task<Result<Selector>> GetDealPaymentStatuses() 
            => await GetEndpoint<Selector>("/deal_payment_statuses");

        public async Task<Result<Selector>> GetTerritories() 
            => await GetEndpoint<Selector>("/territories");

        public async Task<Result<Selector>> GetCampaigns() 
            => await GetEndpoint<Selector>("/campaigns");

        public async Task<Result<Selector>> GetOwners() 
            => await GetEndpoint<Selector>("/owners");

        public async Task<Result<Selector>> GetCurrencies() 
            => await GetEndpoint<Selector>("/currencies");

        public async Task<Result<Selector>> GetContactStatuses() 
            => await GetEndpoint<Selector>("/contact_statuses");

        public async Task<Result<Selector>> GetBusinessTypes() 
            => await GetEndpoint<Selector>("/business_types");

        public async Task<Result<Selector>> GetLifecycleStages() 
            => await GetEndpoint<Selector>("/lifecycle_stages");

        public async Task<Result<Selector>> GetIndustryTypes() 
            => await GetEndpoint<Selector>("/industry_types");

        private async Task<Result<TEntity>> GetEndpoint<TEntity>(string path)
        {
            string endpoint = $"{GetEndpoint<TEntity>()}{path}";
            return await GetApiRequest<TEntity>(endpoint);
        }

    }
}
