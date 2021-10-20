using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Models
{
    public class Meta
    {
        [JsonProperty("total_pages")]
        public int? TotalPages { get; set; } = null;

        [JsonProperty("total")]
        public int? Total { get; set; } = null;

        [JsonProperty("avatar_data")]
        public JObject AvatarData { get; set; } = null;
    }
}
