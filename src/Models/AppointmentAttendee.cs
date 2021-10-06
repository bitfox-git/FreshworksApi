using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class AppointmentAttendee
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("attendee")]
        public Attendee Attendee { get; set; } = null;
    }
}
