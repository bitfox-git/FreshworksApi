using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Models
{

    //    "errors": {
    //        "code": 403,
    //        "message": [
    //            "U bent niet bevoegd om deze bewerking uit te voeren."
    //        ]
    //}
    public class Error
    {
        [JsonProperty("code")]
        public int? Code { get; set; } = null;

        [JsonProperty("message")]
        public List<string> Message { get; set; } = null;
    }
}
