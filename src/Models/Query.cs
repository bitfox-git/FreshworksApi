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

        public async Task<Result<T>> FetchAll<T>() where T : IHasFilters
            => await GetRequest<T>($"{GetEndpoint<T>()}/filters");

        public async Task<Result<T>> GetByID<T>(T body) where T : IHasView, IHasUniqueID
            => await GetByID<T>((long)body.ID);

        public async Task<Result<T>> GetByID<T>(long id) where T : IHasView
        {
            if(id == 0)
            {
                throw new ArgumentException("Missing `ID` in request");
            }

            return await GetRequest<T>($"{GetEndpoint<T>()}/{id}");
        }
        
        public async Task<Result<T>> GetAllByID<T>(T body) where T : IHasAllView, IHasUniqueID
            => await GetAllByID<T>((long)body.ID);

        public async Task<Result<T>> GetAllByID<T>(long id) where T : IHasAllView
        {
            if(id == 0)
            {
                throw new ArgumentException("Missing `ID` in request");
            }

            return await GetRequest<T>($"{GetEndpoint<T>()}/view/{id}");
        }

        public async Task<Result<T>> GetAllByFilter<T>(string filter) where T : IHasView
            => await GetRequest<T>($"{GetEndpoint<T>()}?filter={filter}");

        public async Task<Result<T>> GetAllFileAndLinks<T>(T body) where T : IHasFileAndLinks
            => await GetAllFileAndLinks<T>((long)body.ID);

        public async Task<Result<T>> GetAllFileAndLinks<T>(long id) where T : IHasFileAndLinks
        {
            if (id == 0)
            {
                throw new ArgumentException("Missing `ID` in request");
            }

            var paths = GetEndpoint<T>().Split("\\");
            return await GetRequest<T>($"/{paths[^1]}/{id}/document_associations");
        }

        public async Task<Result<T>> GetAllActivitiesByID<T>(T body) where T : IHasActivities, IHasUniqueID
            => await GetAllActivitiesByID<T>((long)body.ID);

        public async Task<Result<T>> GetAllActivitiesByID<T>(long id) where T : IHasActivities
            => await GetRequest<T>($"/{id}/activities.json");

        public async Task<Result<T>> GetAllFields<T>() where T: IHasFields
        {
            string lastName = GetEndpoint<T>().Split("/").Last();
            return await GetRequest<T>($"/api/settings/{lastName}/fields");
        }

        public async Task<Result<Search>> SearchOnQuery(string query)
            => await GetRequest<Search>($"?q={query}");

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
            => await GetRequest<SearchLookup>($"?q={query}&f={field}&entities={entities}");

        // Selectors
        public async Task<Result<Selector>> GetSalesActivityTypes() 
            => await GetRequest<Selector>("/sales_activity_types");

        public async Task<Result<Selector>> GetSalesActivityEntityTypes() 
            => await GetRequest<Selector>("/sales_activity_entity_types");

        public async Task<Result<Selector>> GetSalesActivityOutcomes() 
            => await GetRequest<Selector>("/sales_activity_outcomes");

        public async Task<Result<Selector>> GetSalesActivityOutcomesByID(long id) 
            => await GetRequest<Selector>("/sales_activity_types/{id}/sales_activity_outcomes");

        public async Task<Result<Selector>> GetDealProducts() 
            => await GetRequest<Selector>("/deal_products");

        public async Task<Result<Selector>> GetDealStages() 
            => await GetRequest<Selector>("/deal_stages");

        public async Task<Result<Selector>> GetDealTypes() 
            => await GetRequest<Selector>("/deal_types");

        public async Task<Result<Selector>> GetDealReasons() 
            => await GetRequest<Selector>("/deal_reasons");

        public async Task<Result<Selector>> GetDealPipelines() 
            => await GetRequest<Selector>("/deal_pipelines");

        public async Task<Result<Selector>> GetDealPipelinesByID(long id) 
            => await GetRequest<Selector>($"/deal_pipelines/{id}/deal_stages");

        public async Task<Result<Selector>> GetDealPaymentStatuses() 
            => await GetRequest<Selector>("/deal_payment_statuses");

        public async Task<Result<Selector>> GetTerritories() 
            => await GetRequest<Selector>("/territories");

        public async Task<Result<Selector>> GetCampaigns() 
            => await GetRequest<Selector>("/campaigns");

        public async Task<Result<Selector>> GetOwners() 
            => await GetRequest<Selector>("/owners");

        public async Task<Result<Selector>> GetCurrencies() 
            => await GetRequest<Selector>("/currencies");

        public async Task<Result<Selector>> GetContactStatuses() 
            => await GetRequest<Selector>("/contact_statuses");

        public async Task<Result<Selector>> GetBusinessTypes() 
            => await GetRequest<Selector>("/business_types");

        public async Task<Result<Selector>> GetLifecycleStages() 
            => await GetRequest<Selector>("/lifecycle_stages");

        public async Task<Result<Selector>> GetIndustryTypes() 
            => await GetRequest<Selector>("/industry_types");

        private string AddIncludes(string uri)
        {
            if(Includes.Count > 0)
            {
                uri += uri.Contains("?") ? "&" : "?";
                uri += $"include={string.Join(",", Includes)}";
            }

            return uri;
        }

        protected async Task<Result<TEntity>> GetRequest<TEntity>(string path)
        {
            string endpoint = $"{GetEndpoint<TEntity>()}{path}";
            endpoint = AddIncludes(endpoint);

            return await GetApiRequest<TEntity>(endpoint);
        }

    }
}
