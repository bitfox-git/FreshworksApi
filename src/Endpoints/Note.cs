using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints.Note
{
    [EndpointName("/api/notes")]
    public class Note: IHasInsert<Note>, IHasUpdate, IHasDelete
    {
        [JsonParentProperty]
        [JsonProperty("note")]
        public Note Item { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("success")]
        public string Success { get; set; } = null;

        // Childs
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("targetable_type")]
        public string TargetableType { get; set; } = null;

        [JsonProperty("targetable_id")]
        public long? TargetableID { get; set; } = null;

        [JsonProperty("description")]
        public string Description { get; set; } = null;

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        [JsonProperty("creater_id")]
        public long? CreaterID { get; set; } = null;

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

        [JsonProperty("url")]
        public string Url { get; set; } = null;

        [JsonProperty("duration")]
        public string Duration { get; set; } = null;

        [JsonProperty("has_access")]
        public bool? HasAccess { get; set; } = null;

        [JsonProperty("collab_context")]
        public ColabContext CollabContext { get; set; } = null;




    }
}
