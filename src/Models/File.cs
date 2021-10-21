using Bitfox.Freshworks.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    [EndpointName("/api/documents")]
    public class File
    {

        // file

        // file_name

        // is_shared

        // targetable_id

        // targetable_type


        [JsonProperty("id")]
        public long ID { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

    }
}
