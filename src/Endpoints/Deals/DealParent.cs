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
    public class DealParent : ErrorObject, IDealPayload, IIncludes
    {
        [JsonProperty("deal")]
        public DealModel Deal { get; set; } = null;


        [JsonProperty("deals")]
        public List<DealModel> Deals { get; set; } = null;


        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;


        [JsonProperty("selected_ids")]
        public long[] SelectedIDs { get; set; } = null;


        [JsonProperty("users")]
        public List<User> Users { get; set; } = null;


        [JsonProperty("field_groups")]
        public List<FieldGroup> FieldGroup { get; set; } = null;


        [JsonProperty("fields")]
        public List<Field> Fields { get; set; } = null;


        [JsonProperty("message")]
        public string Message { get; set; } = null;

        public IncludesObject Includes { get; set; } = null;
    }
}
