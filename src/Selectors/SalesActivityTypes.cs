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
    [EndpointName("sales_activity_types")]
    public class SalesActivityTypes: ISelector
    {
        [JsonProperty("sales_activity_types")]
        public List<SalesSelectionResponse> Types { get; set; }
    }
}
