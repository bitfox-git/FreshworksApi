using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bitfox.Freshworks.Selectors
{
    [EndpointName("deal_types")]
    public class DealTypes : ISelector
    {
        [JsonProperty("deal_types")]
        public List<DealSelectionResponse> Types { get; set; }
    }
}
