using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Filter
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("model_class_name")]
        public string ModelClassName { get; set; } = null;

        [JsonProperty("user_id")]
        public long? UserID { get; set; } = null;

        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; } = null;

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

        [JsonProperty("user_name")]
        public string UserName { get; set; } = null;

        [JsonProperty("url")]
        public string Url { get; set; } = null;

        [JsonProperty("current_user_permissions")]
        public List<string> CurrentUserPermissions { get; set; } = null;

    }
}
