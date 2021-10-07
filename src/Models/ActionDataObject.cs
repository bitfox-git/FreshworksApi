using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkModels
{
    public class ActionDataObject
    {
        [JsonProperty("subscription_types_added")]
        public string[] SubscriptionTypesAdded { get; set; }
    }
}
