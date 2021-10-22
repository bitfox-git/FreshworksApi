using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public partial class FileAssociation
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("created_at")]
        public DateTime? Created_at { get; set; } = null;

        [JsonProperty("attachable")]
        public Attachable Attachable { get; set; } = null;

        [JsonProperty("creater_id")]
        public long? CreaterID { get; set; } = null;
    }
}
