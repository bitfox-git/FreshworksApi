using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Outcome
    {
        [JsonProperty("partial")]
        public bool? Partial { get; set; } = null;

        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("sales_activity_type_id")]
        public long? SalesActivityTypeID { get; set; } = null;

        [JsonProperty("position")]
        public int? Position { get; set; } = null;
    }
}
