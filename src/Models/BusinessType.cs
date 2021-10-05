using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class BusinessType: IUniqueID
    {
        //{
        //    "id": 17000288051,
        //    "name": "Analyst",
        //    "position": 1,
        //    "partial": true
        //}

        [JsonProperty("id")]
        public long ID { get; set; }

        [JsonProperty("name")]
        public long Name { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("partial")]
        public long Partial { get; set; }
    }
}
