using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.EndpointFilters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    [EndpointName("/api/document_links")]
    public class FileLink: IHasInsert
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [JsonProperty("url")]
        public string URL { get; set; } = null;

        [JsonProperty("msg")]
        public string Message { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [JsonProperty("is_shared")]
        public bool? IsShared { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [JsonProperty("targetable_id")]
        public long? TargetableID { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [JsonProperty("targetable_type")]
        public string TargetableType { get; set; } = null;

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; } = null;

        [JsonProperty("is_attached")]
        public bool? IsAttached { get; set; } = null;

        [JsonProperty("creater_id")]
        public long? CreaterID { get; set; } = null;

    }
}
