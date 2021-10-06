using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkObjects
{
    public class DealTypesObject : ErrorObject
    {
        [JsonProperty("deal_types")]
        public List<DealStage> Types { get; set; } = null;
    }
}
