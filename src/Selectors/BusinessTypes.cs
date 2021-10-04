using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Selectors
{
    [EndpointName("business_types")]
    public class BusinessTypes: ISelector
    {
        [JsonProperty("business_types")]
        public List<BusinessTypeSelectionResponse> Types { get; set; }
    }
}
