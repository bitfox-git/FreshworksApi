using Bitfox.Freshworks.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    [EndpointName("/api/email-types")]
    public class SubscriptionParent
    {
        [JsonProperty("email-type")]
        public List<Subscription> Subscriptions { get; set; } = null;

        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;
    }
}
