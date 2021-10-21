using Bitfox.Freshworks.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    [EndpointName("/api/lookup")]
    public class SearchLookup
    {

        [JsonProperty("contacts")]
        public Contact Contact { get; set; }

    }
}
