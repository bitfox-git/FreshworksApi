using Bitfox.Freshworks.NetworkModels;
using Bitfox.Freshworks.NetworkObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class AppointmentParent : ErrorObject, IAppointmentPayload
    {
        [JsonProperty("appointment")]
        public AppointmentModel Appointment { get; set; } = null;


        [JsonProperty("appointments")]
        public List<AppointmentModel> Appointments { get; set; } = null;


        [JsonProperty("appointment_attendees")]
        public List<AttendeeObject> AppointmentAttendees { get; set; } = null;


        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;


        [JsonProperty("users")]
        public List<User> Users { get; set; } = null;


        [JsonProperty("contacts")]
        public List<ContactModel> Contacts { get; set; } = null;


    }
}
