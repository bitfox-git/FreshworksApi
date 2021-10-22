using Newtonsoft.Json;

namespace Bitfox.Freshworks.Models
{
    public class Attachable
    {
        [JsonProperty("type")]
        public string Type { get; set; } = null;

        [JsonProperty("id")]
        public long? ID { get; set; } = null;

    }

}
