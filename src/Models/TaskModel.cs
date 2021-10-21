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
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("status")]
        public int? Status { get; set; } = null;

        [JsonProperty("title")]
        public string Title { get; set; } = null;

        [JsonProperty("description")]
        public string Description { get; set; } = null;

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

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

        public void CatchDeleteExceptions()
        {
            List<string> exceptions = new();

            if (ID == null)
            {
                exceptions.Add("Required key `ID` is missing.");
            }

            if (exceptions.Count > 0)
            {
                throw new MissingFieldException(string.Join("\n", exceptions));
            }
        }

        public void CatchInsertExceptions()
        {
            List<string> exceptions = new();

            if (Title == null)
            {
                exceptions.Add("Required key `Title` is missing.");
            }

            if (Description == null)
            {
                exceptions.Add("Required key `Description` is missing.");
            }

            if (CreatedAt == null)
            {
                exceptions.Add("Required key `CreatedAt` is missing.");
            }

            if (UpdatedAt == null)
            {
                exceptions.Add("Required key `UpdatedAt` is missing.");
            }

            if (OwnerID == null)
            {
                exceptions.Add("Required key `OwnerID` is missing.");
            }

            if (CreaterID == null)
            {
                exceptions.Add("Required key `CreaterID` is missing.");
            }

            if (UpdaterID == null)
            {
                exceptions.Add("Required key `UpdaterID` is missing.");
            }

            if (exceptions.Count > 0)
            {
                throw new MissingFieldException(string.Join("\n", exceptions));
            }

        }

        public void CatchUpdateExceptions()
        {
            List<string> exceptions = new();

            if (ID == null)
            {
                exceptions.Add("Required key `ID` is missing.");
            }

            if (exceptions.Count > 0)
            {
                throw new MissingFieldException(string.Join("\n", exceptions));
            }
        }
    
    
    
    
    }
}
