using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Subscription
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("uuid")]
        public string UUID { get; set; } = null;

        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; } = null;

        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; } = null;

        [JsonProperty("owner_id")]
        public long? OwnerID { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("description")]
        public string Description { get; set; } = null;

        [JsonProperty("status")]
        public string Status { get; set; } = null;

        [JsonProperty("choice_id")]
        public string ChoiceID { get; set; } = null;
    }
}
