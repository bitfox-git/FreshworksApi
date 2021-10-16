using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints.Selector
{
    [EndpointName("/api/selector")]
    public class Selector
    {
        [JsonParentProperty]
        [JsonProperty("users")]
        public List<User> Users { get; set; } = null;
    }
}