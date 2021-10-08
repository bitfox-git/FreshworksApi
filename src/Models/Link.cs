using Newtonsoft.Json;

namespace Bitfox.Freshworks.Models
{
    public class Link
    {
        [JsonProperty("conversations")]
        public string Conversations { get; set; } = null;

        [JsonProperty("timeline_feeds")]
        public string TimelineFeeds { get; set; } = null;

        [JsonProperty("document_associations")]
        public string DocumentAssociations { get; set; } = null;

        [JsonProperty("notes")]
        public string Notes { get; set; } = null;

        [JsonProperty("tasks")]
        public string Tasks { get; set; } = null;

        [JsonProperty("appointments")]
        public string Appointments { get; set; } = null;

        [JsonProperty("reminders")]
        public string Reminders { get; set; } = null;

        [JsonProperty("duplicates")]
        public string Duplicates { get; set; } = null;

        [JsonProperty("connections")]
        public string Connections { get; set; } = null;
    }
}
