using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.EndpointFilters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    [EndpointName("/api/documents")]
    public class File : IHasInsertForm
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("url")]
        public string URL { get; set; } = null;

        [JsonProperty("msg")]
        public string Message { get; set; } = null;

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [JsonProperty("is_shared")]
        public bool? IsShared { get; set; } = null;

        [JsonProperty("content_file_size")]
        public int? ContentFileSize { get; set; } = null;

        [JsonProperty("content_content_type")]
        public string ContentContentType { get; set; } = null;

        [JsonProperty("content_updated_at")]
        public DateTime? ContentUpdatedAt { get; set; } = null;

        [JsonProperty("content_file_size_readable")]
        public string ContentFileSizeReadable { get; set; } = null;

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        [JsonProperty("is_attached")]
        public bool? IsAttached { get; set; } = null;

        [JsonProperty("creater_id")]
        public long? CreaterID { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        public string FilePath { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        public string NewFileName { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        public long? TargetableID { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        public string TargetableType { get; set; } = null;

    }
}
