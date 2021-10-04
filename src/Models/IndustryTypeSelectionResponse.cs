using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Models
{
    //"id": 30000000000,
    //"name": "Accounting",
    //"position": 1,
    //"partial": true
    public class IndustryTypeSelectionResponse
    {
        [JsonProperty("id")]
        public long ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("partial")]
        public bool Partial { get; set; }
    }
}
