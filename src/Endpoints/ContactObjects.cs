using Bitfox.Freshworks.NetworkModels;
using Bitfox.Freshworks.NetworkObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class ContactObjects: ErrorObject
    {
        [JsonProperty("contact")]
        public ContactModel Contact { get; set; } = null;


        [JsonProperty("contacts")]
        public List<ContactModel> Contacts { get; set; } = null;


        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;


        [JsonProperty("selected_ids")]
        public long[] SelectedIDs { get; set; } = null;


        [JsonProperty("owner_id")]
        public long? OwnerID { get; set; } = null;


        [JsonProperty("activities")]
        public List<ActivityObject> Activities { get; set; } = null;


        [JsonProperty("field_groups")]
        public List<FieldGroupObject> FieldGroup { get; set; } = null;


        [JsonProperty("fields")]
        public List<FieldObject> Fields { get; set; } = null;


        [JsonProperty("message")]
        public string Message { get; set; } = null;
    }
}
