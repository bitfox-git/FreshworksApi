using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints.Task
{
    [EndpointName("/api/tasks")]
    public class Task : Includes, IHasInsert, IHasUpdate, IHasView, IHasDelete, IHasFilters, IHasUniqueID
    {
        [JsonReturnParentProperty]
        [JsonProperty("task")]
        public Task Item { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;


        // Childs
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

        [JsonProperty("due_date")]
        public DateTime? DueDate { get; set; } = null;

        [JsonProperty("completed_date")]
        public DateTime? CompletedDate { get; set; } = null;

        [JsonProperty("outcome_id")]
        public long? OutcomeID { get; set; } = null;

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



        public void CatchInsertExceptions()
        {
            throw new NotImplementedException();
        }

        public void CatchUpdateExceptions()
        {
            throw new NotImplementedException();
        }
    }
}
