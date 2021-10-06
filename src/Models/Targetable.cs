using Newtonsoft.Json;

namespace Bitfox.Freshworks.Models
{
    public class Targetable
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("type")]
        public string Type { get; set; } = null;

    }
}
