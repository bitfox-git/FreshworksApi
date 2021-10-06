using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkObjects
{
    public class FieldObject
    {
        [JsonProperty("id")]
        public int? ID { get; set; } = null;

        [JsonProperty("label")]
        public string Label { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("type")]
        public string Type { get; set; } = null;

        [JsonProperty("_default")]
        public bool? Default { get; set; } = null;

        [JsonProperty("actionable")]
        public bool? Actionable { get; set; } = null;

        [JsonProperty("position")]
        public int? Position { get; set; } = null;

        [JsonProperty("choices")]
        public object[] Choices { get; set; } = null;

        [JsonProperty("base_model")]
        public string BaseModel { get; set; } = null;

        [JsonProperty("required")]
        public bool? Required { get; set; } = null;

        [JsonProperty("quick_add_position")]
        public int? QuickAddPosition { get; set; } = null;

        [JsonProperty("visible")]
        public bool? Visible { get; set; } = null;

        [JsonProperty("field_group_id")]
        public string FieldGroupID { get; set; } = null;

    }
}
