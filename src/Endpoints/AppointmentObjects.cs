using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class AppointmentObjects : ErrorObject
    {
        [JsonProperty("appointment")]
        public AppointmentModel Appointment { get; set; } = null;


        [JsonProperty("appointments")]
        public List<AppointmentModel> Appointments { get; set; } = null;


        [JsonProperty("appointment_attendees")]
        public List<AppointmentAttendee> AppointmentAttendees { get; set; }


        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;


        [JsonProperty("users")]
        public List<User> Users { get; set; } = null;


        [JsonProperty("contacts")]
        public List<ContactModel> Contacts { get; set; } = null;


    }
}
