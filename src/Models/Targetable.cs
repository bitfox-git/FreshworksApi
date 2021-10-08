using Newtonsoft.Json;

namespace Bitfox.Freshworks.Models
{
    public class Targetable
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("first_name")]
        public string FirstName { get; set; } = null;

        [JsonProperty("last_name")]
        public string LastName { get; set; } = null;

        [JsonProperty("work_number")]
        public string WorkNumber { get; set; } = null;

        [JsonProperty("mobile_number")]
        public string MobileNumber { get; set; } = null;

        [JsonProperty("display_name")]
        public string DisplayName { get; set; } = null;

        [JsonProperty("email")]
        public string Email { get; set; } = null;

        [JsonProperty("type")]
        public string Type { get; set; } = null;
    }
}
