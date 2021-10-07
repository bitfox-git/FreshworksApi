using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkModels
{
    public class ActivityObject
    {
        [JsonProperty("action_data")]
        public ActionDataObject ActionData { get; set; } = null;

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        [JsonProperty("automation")]
        public object Automation { get; set; } = null;

        [JsonProperty("group")]
        public object Group { get; set; } = null;

        [JsonProperty("targetable_id")]
        public long? TargetableID { get; set; } = null;

        [JsonProperty("targetable_name")]
        public object TargetableName { get; set; } = null;

        [JsonProperty("targetable_type")]
        public string TargetableType { get; set; } = null;

        [JsonProperty("id")]
        public string ID { get; set; } = null;

        [JsonProperty("composite_id")]
        public string CompositeID { get; set; } = null;

        [JsonProperty("action_type")]
        public string ActionType { get; set; } = null;

        [JsonProperty("user_activity")]
        public bool? UserActivity { get; set; } = null;

        [JsonProperty("actionable_id")]
        public object ActionableID { get; set; } = null;

        [JsonProperty("actionable_type")]
        public object ActionableType { get; set; } = null;
    }
}
