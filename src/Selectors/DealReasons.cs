using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bitfox.Freshworks.Selectors
{
    [EndpointName("deal_reasons")]
    public class DealReasons : ISelector
    {
        [JsonProperty("deal_reasons")]
        public List<DealSelectionResponse> Reasons { get; set; }
    }
}
