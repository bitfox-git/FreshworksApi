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
        // {
        //      "field_name": "amount",
        //      "position": 1,
        //      "highlight": true
        // }

        [JsonProperty("field_name")]
        public string FieldName { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("highlight")]
        public bool Highlight { get; set; }
    }
}
