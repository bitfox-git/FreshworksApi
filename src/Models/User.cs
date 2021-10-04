using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Models
{
    //    "id": 31234515422,
    //    "display_name": "John Doe",
    //    "email": "john@email.nl",
    //    "is_active": true,
    //    "work_number": "+31600000000",
    //    "mobile_number": "+31600000000"
    public class User
    {
        [JsonProperty("id")]
        public long ID { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        [JsonProperty("work_number")]
        public string WorkNumber { get; set; }

        [JsonProperty("mobile_number")]
        public string MobileNumber { get; set; }
    }
}
