using Bitfox.Freshworks.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    [EndpointName("/api/lists")]
    public class ListParent
    {
        [JsonProperty("lists")]
        public List<ListItem> Lists { get; set; } = null;

        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;
    }
}
