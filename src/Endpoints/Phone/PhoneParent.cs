using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public class PhoneParent : ErrorObject, IPhonePayload, IIncludes
    {
        [JsonProperty("phone_call")]
        public PhoneModel Call { get; set; } = null;

        [JsonProperty("phone_calls")]
        public PhoneModel Calls { get; set; } = null;

        [JsonProperty("contacts")]
        public List<ContactModel> Contacts { get; set; } = null;

        [JsonProperty("phone_numbers")]
        public List<string> PhoneNumbers { get; set; } = null;

        [JsonProperty("phone_callers")]
        public List<string> PhoneCallers { get; set; } = null;

        [JsonProperty("notes")]
        public List<NoteModel> Notes { get; set; } = null;

        [JsonProperty("user")]
        public List<User> Users { get; set; } = null;

        [JsonProperty("targetables")]
        public List<Targetable> Targetables { get; set; } = null;

        public IncludesObject Includes { get; set; } = null;
    }
}
