using Bitfox.Freshworks.Endpoints.Contact;
using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using Bitfox.Freshworks.NetworkObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public class ContactParent: BaseResponse, IContactPayload
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
        public List<Activity> Activities { get; set; } = null;

        [JsonProperty("field_groups")]
        public List<FieldGroup> FieldGroup { get; set; } = null;

        [JsonProperty("fields")]
        public List<Field> Fields { get; set; } = null;

        [JsonProperty("message")]
        public string Message { get; set; } = null;
    }
}
