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

        [JsonProperty("url")]
        public string URL { get; set; } = null;

        [JsonProperty("msg")]
        public string Message { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("is_shared")]
        public bool? IsShared { get; set; } = null;

        [JsonProperty("targetable_id")]
        public long? TargetableID { get; set; } = null;

        [JsonProperty("targetable_type")]
        public string TargetableType { get; set; } = null;

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; } = null;

        [JsonProperty("is_attached")]
        public bool? IsAttached { get; set; } = null;

        [JsonProperty("creater_id")]
        public long? CreaterID { get; set; } = null;

        public void CatchInsertExceptions()
        {
            List<string> exceptions = new();

            if (URL == null)
            {
                exceptions.Add("Required key `URL` is missing.");
            }

            if (IsShared == null)
            {
                exceptions.Add("Required key `IsShared` is missing.");
            }

            if (TargetableID == null)
            {
                exceptions.Add("Required key `TargetableID` is missing.");
            }

            if (TargetableType == null)
            {
                exceptions.Add("Required key `TargetableType` is missing.");
            }

            if (Name == null)
            {
                exceptions.Add("Required key `Name` is missing.");
            }

            if (exceptions.Count > 0)
            {
                throw new MissingFieldException(string.Join("\n", exceptions));
            }

        }

    }
}
