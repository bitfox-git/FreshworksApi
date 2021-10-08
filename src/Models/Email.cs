using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Email
    {
        [JsonProperty("id")]
        public long? ID { get; protected set; } = null;

        [JsonProperty("value")]
        public string Value { get; protected set; } = null;

        [JsonProperty("is_primary")]
        public bool? IsPrimary { get; protected set; } = null;

        [JsonProperty("label")]
        public object Label { get; protected set; } = null;

        [JsonProperty("_destroy")]
        public bool? Destroy { get; protected set; } = null;
    }
}
