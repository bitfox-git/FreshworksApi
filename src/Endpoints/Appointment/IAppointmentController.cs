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
        /// Insert a new contact item.
        /// </summary>
        /// <param name="payload">New appointment account payload.</param>
        Task<AppointmentParent> Create(IAppointmentPayload payload, Params _params=null);

        /// <summary>
        /// Get all appointments from given user ID.
        /// </summary>
        /// <param name="id">User ID</param>
        Task<AppointmentParent> GetAllByID(long id, Params _params=null);

        /// <summary>
        /// Get appointment information from user ID.
        /// </summary>
        /// <param name="id">Appointment ID</param>
        Task<AppointmentParent> GetByID(long id, Params _params=null);

        /// <summary>
        /// Update appointment information on appointment ID.
        /// </summary>
        /// <param name="id">Appointment ID</param>
        /// <param name="payload">Payload used to update appointment</param>
        Task<AppointmentParent> UpdateByID(long id, IAppointmentPayload payload, Params _params=null);

        /// <summary>
        /// Remove appointment by appointment ID.
        /// </summary>
        /// <param name="id">Appointment ID</param>
        //Task<bool> DeleteByID(long id, Params _params=null);
    }
}
