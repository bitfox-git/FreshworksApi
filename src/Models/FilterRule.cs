using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class FilterRule
    {
        [JsonProperty("attribute ")]
        public string Attribute { get; set; } = null;

        [JsonProperty("operator")]
        public string Operator { get; set; } = null;

        [JsonProperty("value")]
        public string Value { get; set; } = null;

    }
}
