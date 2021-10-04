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
    [EndpointName("sales_activity_outcomes")]
    public class SalesActivityOutcomes: ISelector
    {
        [JsonProperty("sales_activity_outcomes")]
        public List<SalesSelectionResponse> Outcomes { get; set; }
    }
}
