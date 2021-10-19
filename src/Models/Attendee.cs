using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Attendee
    {
        [JsonProperty("id")]
        public int? ID { get; set; } = null;

        [JsonProperty("attendee")]
        public Attendee SingleAttendee { get; set; } = null;

        [JsonProperty("attendee_id")]
        public long? AttendeeID { get; set; } = null;

        [JsonProperty("attendee_type")]
        public string AttendeeType { get; set; } = null;

        [JsonProperty("type")]
        public string Type { get; set; } = null;
    }
}
