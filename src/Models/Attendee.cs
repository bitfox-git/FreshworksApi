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
        [JsonProperty("type")]
        public string Type { get; set; } = null;

        [JsonProperty("id")]
        public int? ID { get; set; } = null;
    }
}
