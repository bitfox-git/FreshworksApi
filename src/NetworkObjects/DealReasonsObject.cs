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
    public class DealReasonsObject: ErrorObject
    {
        [JsonProperty("deal_reasons")]
        public List<DealStage> Reasons { get; set; } = null;
    }
}
