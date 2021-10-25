using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface IContact
    {
        /// <summary>
        /// Include data to this model.
        /// </summary>
        /// <param name="include">name of table</param>
        IQuery Include(string include);

        /// <summary>
        /// Insert a new contact item.
        /// </summary>
        /// <param name="body">New contact item payload</param>
        Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert;

        /// <summary>
        /// Get A Account on ID
        /// </summary>
        /// <typeparam name="T">Account class get endpoint from</typeparam>
        /// <param name="body">New account account payload</param>
        Task<Result<T>> GetByID<T>(T body) where T : IHasView, IHasUniqueID;

        /// <summary>
        /// Get A Account on ID
        /// </summary>
        /// <typeparam name="T">Account class get endpoint from</typeparam>
        /// <param name="id">Account ID</param>
        Task<Result<T>> GetByID<T>(long? id) where T : IHasView;

        /// <summary>
        /// Get All Accounts on ID
        /// </summary>
        /// <typeparam name="T">Account class get endpoint from</typeparam>
        /// <param name="body">New account account payload</param>
        Task<Result<T>> GetAllByID<T>(T body) where T : IHasAllView, IHasUniqueID;

        /// <summary>
        /// Get All Accounts on ID
        /// </summary>
        /// <typeparam name="T">Account class get endpoint from</typeparam>
        /// <param name="id">Account ID</param>
        Task<Result<T>> GetAllByID<T>(long? id) where T : IHasAllView;

        /// <summary>
        /// Update contact information on contact ID.
        /// </summary>
        /// <param name="body">Contact ID and contact used for update</param>
        Task<Result<TEntity>> Update<TEntity>(TEntity body) where TEntity : IHasUpdate;

        /// <summary>
        /// Clone a contact by using his ID.
        /// </summary>
        /// <param name="body">Contact ID and content used for cloning</param>
        Task<Result<TEntity>> Clone<TEntity>(TEntity body) where TEntity : IHasClone;

        /// <summary>
        /// Remove contact by contact ID.
        /// </summary>
        /// <param name="body">Contact ID</param>
        Task<Result<bool>> Delete<TEntity>(TEntity body) where TEntity : IHasDelete;

        /// <summary>
        /// Remove contact by contact ID.
        /// </summary>
        /// <param name="id">Contact ID</param>
        Task<Result<bool>> Delete<TEntity>(long? id) where TEntity : IHasDelete;

        /// <summary>
        /// Hard delete a contact and all the associated data.
        /// </summary>
        /// <param name="body">Contact contains ID that will been deleted</param>
        Task<Result<bool>> Forget<TEntity>(TEntity body) where TEntity : IHasForget;

        /// <summary>
        /// Hard delete a contact and all the associated data.
        /// </summary>
        /// <param name="id">ID that will been deleted</param>
        Task<Result<bool>> Forget<TEntity>(long? id) where TEntity : IHasForget;

        /// <summary>
        /// Assign contacts in bulk.
        /// </summary>
        /// <param name="body">Contact contains needed data for deletion</param>
        Task<Result<TEntity>> AssignBulk<TEntity>(TEntity body) where TEntity : IHasAssignBulk;

        /// <summary>
        /// Delete contacts in bulk.
        /// </summary>
        /// <param name="body">Contact contains needed data for deletion</param>
        Task<Result<TEntity>> DeleteBulk<TEntity>(TEntity body) where TEntity : IHasDeleteBulk;

        /// <summary>
        /// Get Contact Activities
        /// </summary>
        Task<Result<T>> GetAllActivitiesByID<T>(T body) where T : IHasActivities, IHasUniqueID;

        /// <summary>
        /// Get Contact Activities
        /// </summary>
        Task<Result<T>> GetAllActivitiesByID<T>(long? id) where T : IHasActivities;

        /// <summary>
        /// Get Contact Fields
        /// </summary>
        Task<Result<T>> GetAllFields<T>() where T : IHasFields;

        /// <summary>
        /// Get Contact Filters
        /// </summary>
        Task<Result<T>> FetchAll<T>() where T : IHasFilters;

    }
}