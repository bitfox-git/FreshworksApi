using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bitfox.Freshworks.Selectors
{
    [EndpointName("deal_pipelines")]
    public class DealPipelines : ISelector
    {
        [JsonProperty("deal_pipelines")]
        public List<DealSelectionResponse> Pipelines { get; set; }
    }
}
