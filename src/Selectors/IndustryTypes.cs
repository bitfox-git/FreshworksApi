using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Selectors
{
    [EndpointName("industry_types")]
    public class IndustryTypes : ISelector
    {
        [JsonProperty("industry_types")]
        public List<IndustryTypeSelectionResponse> Types { get; set; }
    }
}
