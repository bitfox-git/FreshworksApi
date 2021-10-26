using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface IAppointment
    {
        /// <summary>
        /// Include data to this model.
        /// </summary>
        /// <param name="include">name of table</param>
        IQuery Include(string include);

        /// <summary>
        /// Get Appointment Fields
        /// </summary>
        Task<Result<T>> GetAllFields<T>() where T : IHasFields;

        /// <summary>
        /// Get Appointment Filters
        /// </summary>
        Task<Result<T>> FetchAll<T>() where T : IHasFilters;

        /// <summary>
        /// Add filters parameter
        /// </summary>
        Task<Result<T>> GetAllByFilter<T>(string filter) where T : IHasView;

        /// <summary>
        /// Insert a new Tasks item.
        /// </summary>
        /// <param name="body">New appointment item payload</param>
        Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert;

        /// <summary>
        /// Get A Appointment on ID
        /// </summary>
        /// <typeparam name="T">Appointment class get endpoint from</typeparam>
        /// <param name="body">New appointment payload</param>
        Task<Result<T>> GetByID<T>(T body) where T : IHasView, IHasUniqueID;

        /// <summary>
        /// Get A Appointment on ID
        /// </summary>
        /// <typeparam name="T">Appointment class get endpoint from</typeparam>
        /// <param name="id">Appointment ID</param>
        Task<Result<T>> GetByID<T>(long id) where T : IHasView;

        /// <summary>
        /// Get All Appointment on ID
        /// </summary>
        /// <typeparam name="T">Appointment class get endpoint from</typeparam>
        /// <param name="body">New Appointment payload</param>
        Task<Result<T>> GetAllByID<T>(T body) where T : IHasAllView<T>, IHasUniqueID;

        /// <summary>
        /// Get All Appointments on ID
        /// </summary>
        /// <typeparam name="T">Appointment class get endpoint from</typeparam>
        /// <param name="id">Appointment ID</param>
        Task<Result<T>> GetAllByID<T>(long id) where T : IHasAllView<T>;

        /// <summary>
        /// Update appointment information on appointment ID.
        /// </summary>
        /// <param name="body">Appointment ID and appointment used for update</param>
        Task<Result<TEntity>> Update<TEntity>(TEntity body) where TEntity : IHasUpdate;

        /// <summary>
        /// Remove appointment by appointment ID.
        /// </summary>
        /// <param name="body">Appointment ID</param>
        Task<Result<bool>> Delete<TEntity>(TEntity body) where TEntity : IHasDelete;

        /// <summary>
        /// Remove contact by contact ID.
        /// </summary>
        /// <param name="id">Contact ID</param>
        Task<Result<bool>> Delete<TEntity>(long id) where TEntity : IHasDelete;


    }
}
