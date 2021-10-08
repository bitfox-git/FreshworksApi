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
        /// Create a item added to the rest of the content
        /// </summary>
        /// <param name="payload">Model used to create a item with.</param>
        Task<AppointmentParent> Create(IAppointmentPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Get all items from given ID.
        /// </summary>
        /// <param name="id">Content ID</param>
        Task<AppointmentParent> GetAllByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Get Data from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        Task<AppointmentParent> GetByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Update data of item from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        /// <param name="payload">Payload used to update item</param>
        Task<AppointmentParent> UpdateByID(long id, IAppointmentPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Remove Item from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        Task<bool> DeleteByID(long id, string include = null, int? page = null);
    }
}
