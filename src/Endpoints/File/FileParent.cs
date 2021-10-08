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
    public class FileParent : ErrorObject, IFilePayload, IIncludes
    {
        [JsonProperty("users")]
        public List<User> Users { get; set; } = null;

        [JsonProperty("documents")]
        public List<FileModel> Documents { get; set; } = null;

        [JsonProperty("document_links")]
        public List<FileModel> DocumentLinks { get; set; } = null;

        [JsonProperty("url")]
        public string Url { get; set; } = null;

        [JsonProperty("is_shared")]
        public bool? IsShared { get; set; } = null;

        [JsonProperty("targetable_id")]
        public long? TargetableID { get; set; } = null;

        [JsonProperty("targetable_type")]
        public string TargetableType { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        public IncludesParent Includes { get; set; } = null;
    }
}
