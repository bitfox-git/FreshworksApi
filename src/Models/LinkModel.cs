using Newtonsoft.Json;

namespace Bitfox.Freshworks.Models
{
    public class LinkModel
    {
        [JsonProperty("conversations")]
        public string Conversations { get; set; }

        [JsonProperty("timeline_feeds")]
        public string TimelineFeeds { get; set; }

        [JsonProperty("document_associations")]
        public string DocumentAssociations { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("tasks")]
        public string Tasks { get; set; }

        [JsonProperty("appointments")]
        public string Appointments { get; set; }

        [JsonProperty("reminders")]
        public string Reminders { get; set; }

        [JsonProperty("duplicates")]
        public string Duplicates { get; set; }

        [JsonProperty("connections")]
        public string Connections { get; set; }
    }
}
