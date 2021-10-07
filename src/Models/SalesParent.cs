using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class SalesParent: ErrorObject
    {
        [JsonProperty("sales_activity")]
        public SalesModel Activity { get; set; } = null;


        [JsonProperty("sales_activities")]
        public List<SalesModel> Activities { get; set; } = null;


        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;

    }
}
