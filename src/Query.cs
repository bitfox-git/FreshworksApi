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
        protected List<ListItem> AllLists = new();

        public Query(string BaseURL, string apikey) : base(BaseURL, apikey)
        { }



        // Custom
        public async Task<Result<T>> GetPage<T>(long viewID, int page) where T : IHasAllView<T>
        {
            return await GetRequest<T>($"/view/{viewID}?page={page}&perPage=100");
        }

        public async Task<List<T>> GetAll<T>() where T : IHasFilters, IHasAllView<T>
        {
            long viewID = await GetDefaultViewID<T>();
            var result = new List<T>();
            int page = 1;
            int prevCount = 0;

            while (page > 0)
            {
                var records = await GetPage<T>(viewID, page);
                result.AddRange(records.Value.Items);
                if (result.Count < records.Value.Meta.Total && result.Count != prevCount)
                {
                    page++;
                }
                else
                {
                    page = -1;
                }

                prevCount = result.Count;
            }

            return result;
        }

        public async Task<List<ListItem>> GetAllLists()
        {
            if (AllLists.Count > 0) return AllLists;

            int page = 1;
            int prevCount = 0;
            while (page > 0)
            {
                var records = await GetRequest<ListParent>($"?page={page}&perPage=100");
                AllLists.AddRange(records.Value.Lists);

                if (AllLists.Count < records.Value.Meta.Total && AllLists.Count != prevCount)
                {
                    page++;
                }
                else
                {
                    page = -1;
                }

                prevCount = AllLists.Count;
            }

            return AllLists;
        }
        
        public async Task<Contact> AddList(Contact contact, string listName)
        {
            var lists = await GetAllLists();
            var listNames = lists.Select(item => item.Name).ToList();
            var items = lists.Where(i => i.Name == listName).ToList();
            
            if(!listNames.Contains(listName) || items.Count == 0)
            {
                throw new ArgumentException(
                    $"Not a valid listName:`{listName}`\n\noptions:[\n{string.Join("\n", listNames)}]"
                );
            }

            // add list ID
            contact.ListIDs ??= new();
            if (!contact.ListIDs.Contains((long)items.First().ID))
            {
                contact.ListIDs.Add((long)items.First().ID);
            }

            return contact;
        }

        public Contact AddSubscription(Contact contact, long subscriptionType)
        {
            var matched = false;
            var types = contact.SubscriptionTypes.Split(";")
                .Where(x => !string.IsNullOrEmpty(x)).ToList();

            foreach (string type in types)
            {
                if(subscriptionType == long.Parse(type))
                {
                    matched = true;
                    break;
                }
            }

            // Add subscription ID
            if(!matched)
            {
                types.Add(subscriptionType.ToString());
                contact.SubscriptionTypes = string.Join(";", types);
            }

            return contact;
        }


        //////////////////////////////


        // Queries

        public async Task<Result<T>> FetchAll<T>() where T : IHasFilters
            => await GetRequest<T>($"/filters");

        public async Task<Result<T>> GetByID<T>(T body) where T : IHasView, IHasUniqueID
            => await GetByID<T>((long)body.ID);

        public async Task<Result<T>> GetByID<T>(long id) where T : IHasView
            => await GetRequest<T>($"/{id}", id);
        
        public async Task<Result<T>> GetAllByID<T>(T body) where T : IHasAllView<T>, IHasUniqueID
            => await GetAllByID<T>((long)body.ID);

        public async Task<Result<T>> GetAllByID<T>(long id) where T : IHasAllView<T>
            => await GetRequest<T>($"/view/{id}", id);

        public async Task<Result<T>> GetAllByFilter<T>(string filter) where T : IHasView
            => await GetRequest<T>($"?filter={filter}");

        public async Task<Result<T>> GetAllFileAndLinks<T>(T body) where T : IHasFileAndLinks
            => await GetAllFileAndLinks<T>((long)body.ID);

        public async Task<Result<T>> GetAllFileAndLinks<T>(long id) where T : IHasFileAndLinks
        {
            var path = GetEndpoint<T>().Split("\\")[^1];
            return await GetRequest<T>($"/{path}/{id}/document_associations", id);
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

        // Extra

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

        private async Task<long> GetDefaultViewID<T>() where T : IHasFilters
        {
            //first , request the correct filter
            var filters = await FetchAll<T>();

            //This is kind of a hack ? it looks for the "all ....." view for this entity...
            //is this 100% sure?
            var viewId = filters.Value.Filters
                           .Where(x => x.Name.ToLower().StartsWith("all ") && (bool)x.IsDefault)
                           .Select(x => x.ID)
                           .FirstOrDefault();

            return (long)viewId;
        }

        protected async Task<Result<TEntity>> GetRequest<TEntity>(string path, long? id = null)
        {
            if (id != null && id == 0)
            {
                throw new ArgumentException("Missing `ID` in request");
            }

            string endpoint = $"{GetEndpoint<TEntity>()}{path}";
            endpoint = AddIncludes(endpoint);

            return await GetApiRequest<TEntity>(endpoint);
        }

    }
}
