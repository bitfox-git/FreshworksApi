using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    [EndpointName("/api/tasks")]
    public class TaskModel : Includes, IHasInsert, IHasUpdate, IHasView, IHasDelete, IHasFilters, IHasUniqueID
    {
        
        [JsonProperty("task")]
        public TaskModel Item { get; set; } = null;

        
        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;

        
        [JsonProperty("filters")]
        public List<Filter> Filters { get; set; } = null;

        
        [JsonProperty("success")]
        public int? Success { get; set; } = null;


        // Childs

        [IsRequiredOn(nameof(IHasDelete))]
        [IsRequiredOn(nameof(IHasUpdate))]
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("status")]
        public int? Status { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [JsonProperty("title")]
        public string Title { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [JsonProperty("description")]
        public string Description { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

        [JsonProperty("due_date")]
        public DateTime? DueDate { get; set; } = null;

        [JsonProperty("completed_date")]
        public DateTime? CompletedDate { get; set; } = null;

        [JsonProperty("outcome_id")]
        public long? OutcomeID { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [JsonProperty("owner_id")]
        public long? OwnerID { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [JsonProperty("creater_id")]
        public long? CreaterID { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [JsonProperty("updater_id")]
        public long? UpdaterID { get; set; } = null;

        [JsonProperty("task_type_id")]
        public long? TaskTypeID { get; set; } = null;

        [JsonProperty("user_ids")]
        public List<long> UserIDs { get; set; } = null;

        [JsonProperty("targetable")]
        public User Targetable { get; set; } = null;

        [JsonProperty("targetable_id")]
        public long? TargetableID { get; set; } = null;

        [JsonProperty("targetable_type")]
        public string TargetableType { get; set; } = null;

        [JsonProperty("task_users_attributes")]
        public List<User> TaskUsersAttributes { get; set; } = null;    
    
    }
}
