using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public partial class TaskModel
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("status")]
        public int? Status { get; set; } = null;

        [JsonProperty("title")]
        public string Title { get; set; } = null;

        [JsonProperty("description")]
        public string Description { get; set; } = null;

        [JsonProperty("created_at")]
        public DateTime? Created_at { get; set; } = null;

        [JsonProperty("updated_at")]
        public DateTime? Updated_at { get; set; } = null;

        [JsonProperty("owner_id")]
        public long? OwnerID { get; set; } = null;

        [JsonProperty("due_date")]
        public DateTime? DueDate { get; set; } = null;

        [JsonProperty("creater_id")]
        public long? CreaterID { get; set; } = null;

        [JsonProperty("user_ids")]
        public List<long> UserIDs { get; set; } = null;

        [JsonProperty("targetable")]
        public Targetable Targetable { get; set; } = null;

        [JsonProperty("targetable_id")]
        public string TargetableID { get; set; } = null;

        [JsonProperty("targetable_type")]
        public string TargetableType { get; set; } = null;

        [JsonProperty("task_users_attributes")]
        public List<TaskUserAttribute> TaskUsersAttributes { get; set; } = null;

    }
}
