using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class StageLifecycle
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("position")]
        public int? Position { get; set; } = null;

        [JsonProperty("disabled")]
        public bool? Disabled { get; set; } = null;

        [JsonProperty("_default")]
        public bool? Default { get; set; } = null;

        [JsonProperty("type")]
        public string Type { get; set; } = null;

        [JsonProperty("contact_status_ids")]
        public long[] ContactStatusIDs { get; set; } = null;
    }
}
