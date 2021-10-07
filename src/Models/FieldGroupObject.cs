using Newtonsoft.Json;

namespace Bitfox.Freshworks.NetworkModels
{
    public class FieldGroupObject
    {
        [JsonProperty("id")]
        public string ID { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("model")]
        public string Model { get; set; } = null;
    }
}