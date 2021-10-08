using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Config
    {
        [JsonProperty("field_name")]
        public string FieldName { get; set; } = null;

        [JsonProperty("position")]
        public int? Position { get; set; } = null;

        [JsonProperty("highlight")]
        public bool? Highlight { get; set; } = null;
    }
}
