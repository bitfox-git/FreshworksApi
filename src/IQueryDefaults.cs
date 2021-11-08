using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface IQueryDefaults
    {
        /// <summary>
        /// Get a single model
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="body">Model ID used to get the model</param>
        Task<Result<T>> GetByID<T>(T body) where T : IHasView, IHasUniqueID;

        /// <summary>
        /// Get a single model
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="id">Used to get the model</param>
        Task<Result<T>> GetByID<T>(long id) where T : IHasView;

        /// <summary>
        /// Get all models
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="body">Model ID used to get the models</param>
        Task<Result<T>> GetAllByID<T>(T body) where T : IHasAllView<T>, IHasUniqueID;

        /// <summary>
        /// Get all models
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="id">Used to get the models</param>
        Task<Result<T>> GetAllByID<T>(long id) where T : IHasAllView<T>;

        /// <summary>
        /// Get all models by filters
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="filter">Value to filter on.</param>
        Task<Result<T>> GetAllByFilter<T>(string filter) where T : IHasView;

        /// <summary>
        /// Get all Files and Links
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="body">Model ID to get data from.</param>
        Task<Result<T>> GetAllFileAndLinks<T>(T body) where T : IHasFileAndLinks;

        /// <summary>
        /// Get all Files and Links
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="id">ID to get data from</param>
        Task<Result<T>> GetAllFileAndLinks<T>(long id) where T : IHasFileAndLinks;

        /// <summary>
        /// Get all Activities
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="body">Model ID to get data from.</param>
        Task<Result<T>> GetAllActivitiesByID<T>(T body) where T : IHasActivities, IHasUniqueID;

        /// <summary>
        /// Get all Activities
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="id">ID to get data from.</param>
        Task<Result<T>> GetAllActivitiesByID<T>(long id) where T : IHasActivities;

        /// <summary>
        /// Get all Filters
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        Task<Result<T>> GetAllFields<T>() where T : IHasFields;


        /// <summary>
        /// Search in content what do actually match
        /// </summary>
        /// <param name="query">returning data contains this query</param>
        Task<Result<Search>> SearchOnQuery(string query);

        /// <summary>
        /// Get all content of TEntity from database, than filter data on SearchOnFilter model.
        /// </summary>
        /// <typeparam name="TEntity">Model you want to get data from</typeparam>
        /// <param name="body">The Value that you want to filter</param>
        Task<Result<SearchFilter>> SearchOnFilter<TEntity>(SearchFilter body) where TEntity : IHasFilteredSearch;

        /// <summary>
        /// Lookup in data with some filters specified.
        /// </summary>
        /// <param name="query">lookup for this string in models</param>
        /// <param name="field">data from given field ()</param>
        /// <param name="entities">entities to get data from</param>
        Task<Result<SearchLookup>> SearchOnLookup(string query, string field, string entities);



        // Selectors

        /// <summary>
        /// Fetch all existing sales activity types' details in the Freshsales portal.
        /// Will give id, name of the sales activity types.
        /// </summary>
        Task<Result<Selector>> GetSalesActivityTypes();

        /// <summary>
        /// Fetch all existing sales activity entity types' details in the Freshsales portal.
        /// Will give id, name of the sales activity entity types.
        /// </summary>
        Task<Result<Selector>> GetSalesActivityEntityTypes();

        /// <summary>
        /// Fetch all existing sales activity outcomes' details in the Freshsales portal.
        /// Will give id, name of the sales activity outcomes.
        /// </summary>
        Task<Result<Selector>> GetSalesActivityOutcomes();

        /// <summary>
        /// Fetch all existing sales activity outcomes' details only of the sales activity type specified.
        /// Will give id, name, sales_activity_type_id of the sales activity outcomes.
        /// </summary>
        Task<Result<Selector>> GetSalesActivityOutcomesByID(long id);

        /// <summary>
        /// Fetch all existing deal stages' details of default pipeline in the Freshsales portal.
        /// Will give id, name, deal_pipeline_id of the deal stages.
        /// </summary>
        Task<Result<Selector>> GetDealProducts();

        /// <summary>
        /// Fetch all existing deal stages' details of default pipeline in the Freshsales portal.
        /// Will give id, name, deal_pipeline_id of the deal stages.
        /// </summary>
        Task<Result<Selector>> GetDealStages();

        /// <summary>
        /// Fetch all existing deal types' details in the Freshsales portal.
        /// Will give id, name of the deal types
        /// </summary>
        Task<Result<Selector>> GetDealTypes();


        /// <summary>
        /// Fetch all existing deal reasons' details in the Freshsales portal.
        /// Will give id, name of the deal reasons
        /// </summary>
        Task<Result<Selector>> GetDealReasons();


        /// <summary>
        /// Fetch all existing deal pipelines' details in the Freshsales portal.
        /// Will give id, name of the deal pipelines
        /// </summary>
        Task<Result<Selector>> GetDealPipelines();

        /// <summary>
        /// Fetch all existing deal_stages' details only of the pipeline specified.
        /// Will give id, name, deal_pipeline_id of the deal stages.
        /// </summary>
        Task<Result<Selector>> GetDealPipelinesByID(long id);

        /// <summary>
        /// Fetch all existing deal payment statuses' details in the Freshsales portal.
        /// Will give id, name of the deal payment statuses
        /// </summary>
        Task<Result<Selector>> GetDealPaymentStatuses();

        /// <summary>
        /// Get all territories from this subdomain
        /// </summary>
        Task<Result<Selector>> GetTerritories();

        /// <summary>
        /// Get all campaigns from this subdomain
        /// </summary>
        Task<Result<Selector>> GetCampaigns();

        /// <summary>
        /// Get all owners from this subdomain
        /// </summary>
        Task<Result<Selector>> GetOwners();

        /// <summary>
        /// Get all currencies from this subdomain
        /// </summary>
        Task<Result<Selector>> GetCurrencies();

        /// <summary>
        /// Get all contact statuses from this subdomain
        /// </summary>
        Task<Result<Selector>> GetContactStatuses();

        /// <summary>
        /// Get all business types from this subdomain
        /// </summary>
        Task<Result<Selector>> GetBusinessTypes();

        /// <summary>
        /// Get all lifecycle stages from this subdomain
        /// </summary>
        Task<Result<Selector>> GetLifecycleStages();
        
        /// <summary>
        /// Get all industry types from this subdomain
        /// </summary>
        Task<Result<Selector>> GetIndustryTypes();

    }
}
