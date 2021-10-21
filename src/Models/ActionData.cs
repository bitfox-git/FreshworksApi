using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class ActionData
    {
        [JsonProperty("subscription_types_added")]
        public List<string> SubscriptionTypesAdded { get; set; } = null;
    }
}
