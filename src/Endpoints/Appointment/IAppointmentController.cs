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
        /// Create a new contact item.
        /// </summary>
        /// <param name="payload">New appointment account payload.</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<AppointmentParent> Create(IAppointmentPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Get all appointments from given user ID.
        /// </summary>
        /// <param name="id">User ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<AppointmentParent> GetAllByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Get appointment information from user ID.
        /// </summary>
        /// <param name="id">Appointment ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<AppointmentParent> GetByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Update appointment information on appointment ID.
        /// </summary>
        /// <param name="id">Appointment ID</param>
        /// <param name="payload">Payload used to update appointment</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<AppointmentParent> UpdateByID(long id, IAppointmentPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Remove appointment by appointment ID.
        /// </summary>
        /// <param name="id">Appointment ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<bool> DeleteByID(long id, string include = null, int? page = null);
    }
}
