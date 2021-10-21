using Bitfox.Freshworks.Endpoints.Selector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Query: Network, ISelectorController
    {
        private List<string> Includes = new();

        public Query(string BaseURL, string apikey) : base(BaseURL, apikey)
        { }

        public Query Include(string include)
        {
            Includes.Add(include);
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
            uri += Includes.Count > 0 ? $"?include={string.Join(",", Includes)}" : "";
            return await GetApiRequest<TEntity>(uri);
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
            uri += Includes.Count > 0 ? $"&include={string.Join(",", Includes)}" : "";
            return await GetApiRequest<TEntity>(uri);
        }

        public async Task<Result<TEntity>> GetAllByFilter<TEntity>(string filter) where TEntity : IHasView
        {
            var endpoint = GetEndpoint<TEntity>();
            var uri = $"{endpoint}?filter={filter}";

            //add includes
            uri += Includes.Count > 0 ? $"&include={string.Join(",", Includes)}" : "";
            return await GetApiRequest<TEntity>(uri);
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
            uri += Includes.Count > 0 ? $"&include={string.Join(",", Includes)}" : "";
            return await GetApiRequest<TEntity>(uri);
        }

        public async Task<Result<TEntity>> GetAllFields<TEntity>() where TEntity: IHasFields
        {
            var endpoint = GetEndpoint<TEntity>();
            string lastName = endpoint.Split("/").Last();
            string url = $"/api/settings/{lastName}/fields";

            //add includes
            url += Includes.Count > 0 ? $"&include={string.Join(",", Includes)}" : "";
            return await GetApiRequest<TEntity>(url);
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
