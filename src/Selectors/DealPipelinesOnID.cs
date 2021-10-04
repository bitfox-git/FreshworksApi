using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bitfox.Freshworks.Selectors
{
    [EndpointName("/deal_pipelines/[id]/deal_stages")]
    public class DealPipelinesOnID : ISelector
    {
        [JsonProperty("deal_stages")]
        public List<DealSelectionResponse> Stages { get; set; }
    }
}
