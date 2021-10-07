using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;

namespace Bitfox.Freshworks.Endpoints
{
    public class FilePayload: ErrorObject
    {
        [JsonProperty("url")]
        public string Url { get; set; } = null;

        [JsonProperty("is_shared")]
        public bool? IsShared { get; set; } = null;

        [JsonProperty("targetable_id")]
        public long? TargetableID { get; set; } = null;

        [JsonProperty("targetable_type")]
        public string TargetableType { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;
    }
}
