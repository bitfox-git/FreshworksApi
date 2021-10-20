using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Endpoints.Selector;
using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    public interface ICRMClient
    {
        /// <summary>
        /// Handles data based on subdomain. [ Query ]
        /// </summary>
        ISelectorController Selector { get; }

        /// <summary>
        /// Handles Contacts Actions. [Insert, Update, Delete etc.]
        /// </summary>
        IContactController Contact { get; }

        /// <summary>
        /// Handles Account Actions. [Insert, Update, Delete etc.]
        /// </summary>
        IAccountController Account { get; }

        /// <summary>
        /// Handles Deals Actions. [Insert, Update, Delete etc.]
        /// </summary>
        IDealController Deal { get; }

        /// <summary>
        /// Handles Notes Actions. [Insert, Update, Delete etc.]
        /// </summary>
        INoteController Note { get; }

        /// <summary>
        /// Handles Task Actions. [Insert, Update, Delete etc.]
        /// </summary>
        ITaskController Task { get; }

        /// <summary>
        /// Handles Appointment Actions. [Insert, Update, Delete etc.]
        /// </summary>
        IAppointmentController Appointment { get; }

        /// <summary>
        /// Handles Appointment Actions. [Insert, Update, Delete etc.]
        /// </summary>
        ISaleController Sales { get; }


        Task<Result<T>> Insert<T>(T item) where T : IHasInsert;

        Task<Result<T>> Update<T>(T item) where T : IHasUpdate;
        
        Task<Result<T>> Clone<T>(T item) where T : IHasClone;
        
        Query Query();
        
        Task<Result<bool>> Delete<T>(T item) where T : IHasDelete;
        
        Task<Result<bool>> Delete<T>(long? id) where T : IHasDelete;
        
        Task<Result<T>> AssignBulk<T>(T item) where T : IHasAssignBulk;
        
        Task<Result<T>> DeleteBulk<T>(T item) where T : IHasDeleteBulk;
        
        Task<Result<bool>> Forget<T>(T item) where T : IHasForget;
        
        Task<Result<bool>> Forget<T>(long? id) where T : IHasForget;
        
        Task<Result<TEntity>> FetchAll<TEntity>() where TEntity : IHasFilters;


        //// Selector

        ///// <summary>
        ///// Fetch all existing sales activity types' details in the Freshsales portal.
        ///// Will give id, name of the sales activity types.
        ///// </summary>
        //Task<Result<Selector>> GetSalesActivityTypes();

        ///// <summary>
        ///// Fetch all existing sales activity entity types' details in the Freshsales portal.
        ///// Will give id, name of the sales activity entity types.
        ///// </summary>
        //Task<Result<Selector>> GetSalesActivityEntityTypes();

        ///// <summary>
        ///// Fetch all existing sales activity outcomes' details in the Freshsales portal.
        ///// Will give id, name of the sales activity outcomes.
        ///// </summary>
        //Task<Result<Selector>> GetSalesActivityOutcomes();

        ///// <summary>
        ///// Fetch all existing sales activity outcomes' details only of the sales activity type specified.
        ///// Will give id, name, sales_activity_type_id of the sales activity outcomes.
        ///// </summary>
        //Task<Result<Selector>> GetSalesActivityOutcomesByID(long id);

        ///// <summary>
        ///// Fetch all existing deal stages' details of default pipeline in the Freshsales portal.
        ///// Will give id, name, deal_pipeline_id of the deal stages.
        ///// </summary>
        //Task<Result<Selector>> GetDealProducts();

        ///// <summary>
        ///// Fetch all existing deal stages' details of default pipeline in the Freshsales portal.
        ///// Will give id, name, deal_pipeline_id of the deal stages.
        ///// </summary>
        //Task<Result<Selector>> GetDealStages();

        ///// <summary>
        ///// Fetch all existing deal types' details in the Freshsales portal.
        ///// Will give id, name of the deal types
        ///// </summary>
        //Task<Result<Selector>> GetDealTypes();


        ///// <summary>
        ///// Fetch all existing deal reasons' details in the Freshsales portal.
        ///// Will give id, name of the deal reasons
        ///// </summary>
        //Task<Result<Selector>> GetDealReasons();


        ///// <summary>
        ///// Fetch all existing deal pipelines' details in the Freshsales portal.
        ///// Will give id, name of the deal pipelines
        ///// </summary>
        //Task<Result<Selector>> GetDealPipelines();

        ///// <summary>
        ///// Fetch all existing deal_stages' details only of the pipeline specified.
        ///// Will give id, name, deal_pipeline_id of the deal stages.
        ///// </summary>
        //Task<Result<Selector>> GetDealPipelinesByID(long id);

        ///// <summary>
        ///// Fetch all existing deal payment statuses' details in the Freshsales portal.
        ///// Will give id, name of the deal payment statuses
        ///// </summary>
        //Task<Result<Selector>> GetDealPaymentStatuses();

        ///// <summary>
        ///// Get all territories from this subdomain
        ///// </summary>
        //Task<Result<Selector>> GetTerritories();

        ///// <summary>
        ///// Get all campaigns from this subdomain
        ///// </summary>
        //Task<Result<Selector>> GetCampaigns();

        ///// <summary>
        ///// Get all owners from this subdomain
        ///// </summary>
        //Task<Result<Selector>> GetOwners();

        ///// <summary>
        ///// Get all currencies from this subdomain
        ///// </summary>
        //Task<Result<Selector>> GetCurrencies();

        ///// <summary>
        ///// Get all contact statuses from this subdomain
        ///// </summary>
        //Task<Result<Selector>> GetContactStatuses();

        ///// <summary>
        ///// Get all business types from this subdomain
        ///// </summary>
        //Task<Result<Selector>> GetBusinessTypes();

        ///// <summary>
        ///// Get all lifecycle stages from this subdomain
        ///// </summary>
        //Task<Result<Selector>> GetLifecycleStages();

        ///// <summary>
        ///// Get all industry types from this subdomain
        ///// </summary>
        //Task<Result<Selector>> GetIndustryTypes();



    }
}
