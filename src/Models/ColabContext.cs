using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class ColabContext
    {
        [JsonProperty("hasSlackViewAccess")]
        public bool? HasSlackViewAccess { get; set; } = null;

        [JsonProperty("messageId")]
        public string MessageId { get; set; } = null;
    }
}
