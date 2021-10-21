using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class UserAttribute
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("work_number")]
        public string WorkNumber { get; set; } = null;

        [JsonProperty("mobile_number")]
        public string MobileNumber { get; set; } = null;

        [JsonProperty("is_active")]
        public bool? IsActive { get; set; } = null;

    }
}
