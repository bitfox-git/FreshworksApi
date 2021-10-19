using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    public interface IAppointmentController
    {
        /// <summary>
        /// Insert a new Task item.
        /// </summary>
        /// <param name="body">New appointment item payload</param>
        Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert<TEntity>, new();

        /// <summary>
        /// Get content from appointment information.
        /// </summary>
        Query Query();

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
        Task<Result<bool>> Delete<TEntity>(long? id) where TEntity : IHasDelete;
    }
}
