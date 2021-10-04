using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Models
{
    //"id": 30001100000,
    //   "value": "user@email.nl",
    //   "is_primary": true,
    //   "label": "Work",
    //   "_destroy": false
    public class ContactEmail
    {
        [JsonProperty("id")]
        public long ID { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("is_primary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("_destroy")]
        public bool IsDestroy { get; set; }
    }
}
