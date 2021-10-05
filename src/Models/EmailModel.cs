using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class EmailModel
    {
        [JsonProperty("id")]
        public long ID { get; protected set; }

        [JsonProperty("value")]
        public string Value { get; protected set; }

        [JsonProperty("is_primary")]
        public bool IsPrimary { get; protected set; }

        [JsonProperty("label")]
        public object Label { get; protected set; }

        [JsonProperty("_destroy")]
        public bool Destroy { get; protected set; }
    }
}
