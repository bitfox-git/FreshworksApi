using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class PhoneNumber
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("value")]
        public string Value { get; set; } = null;

        [JsonProperty("label")]
        public string Label { get; set; } = null;

        [JsonProperty("_destroy")]
        public bool? Destroy { get; set; } = null;
    }
}
