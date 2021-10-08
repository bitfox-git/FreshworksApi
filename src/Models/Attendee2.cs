using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Attendee2
    {
        [JsonProperty("attendee_type")]
        public string AttendeeType { get; set; } = null;

        [JsonProperty("attendee_id")]
        public long? AttendeeID { get; set; } = null;

    }
}
