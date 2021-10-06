using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bitfox.Freshworks.Models
{
    public class AvatarData
    {
        [JsonProperty("SalesAccount")]
        public Dictionary<string, string> SalesAccount { get; set; } = null;
    }
}