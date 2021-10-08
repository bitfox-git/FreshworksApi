using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class SalesModel
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("title")]
        public string Title { get; set; } = null;

        [JsonProperty("start_date")]
        public DateTime? StartDate { get; set; } = null;

        [JsonProperty("end_date")]
        public DateTime? EndDate { get; set; } = null;

        [JsonProperty("sales_activity_type_id")]
        public long? SalesActivityTypeID { get; set; } = null;

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

        [JsonProperty("notes")]
        public string Notes { get; set; } = null;

        [JsonProperty("owner_id")]
        public long? OwnerID { get; set; } = null;

        [JsonProperty("sales_activity_outcome_id")]
        public long? SalesActivityOutcomeID { get; set; } = null;

        [JsonProperty("remote_id")]
        public object RemoteID { get; set; } = null;

        [JsonProperty("import_id")]
        public object ImportID { get; set; } = null;

        [JsonProperty("creater_id")]
        public long? CreaterID { get; set; } = null;

        [JsonProperty("updater_id")]
        public long? UpdaterID { get; set; } = null;

        [JsonProperty("conversation_time")]
        public DateTime? ConversationTime { get; set; } = null;

        [JsonProperty("targetable_id")]
        public long? TargetableID { get; set; } = null;

        [JsonProperty("targetable_type")]
        public string TargetableType { get; set; } = null;

        [JsonProperty("latitude")]
        public string Latitude { get; set; } = null;

        [JsonProperty("longitude")]
        public string Longitude { get; set; } = null;

        [JsonProperty("location")]
        public string Location { get; set; } = null;

        [JsonProperty("checkedin_at")]
        public DateTime? CheckedinAt { get; set; } = null;

        [JsonProperty("success")]
        public string Success { get; set; } = null;

    }
}
