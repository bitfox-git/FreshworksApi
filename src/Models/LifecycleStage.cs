using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class LifecycleStage: IUniqueID
    {
    //  {
    //        "id": 18004287484,
    //        "name": "Lead",
    //        "position": 1,
    //        "disabled": false,
    //        "default": true,
    //        "type": "Lead",
    //        "contact_status_ids": [
    //            17000261978,
    //            17000261979,
    //            17000261980,
    //            17000261981
    //        ]
    //  },

        [JsonProperty("id")]
        public long ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("contact_status_ids")]
        public List<long> ContactStatusIDs { get; set; }

    }
}
