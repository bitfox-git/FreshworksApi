using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class TaskParent: ErrorObject
    {
        [JsonProperty("task")]
        public TaskModel Task { get; set; } = null;


        [JsonProperty("tasks")]
        public List<TaskModel> Tasks { get; set; } = null;


        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;


        [JsonProperty("users")]
        public List<User> Users { get; set; } = null;


        [JsonProperty("contacts")]
        public List<ContactModel> Contacts { get; set; } = null;

    }
}
