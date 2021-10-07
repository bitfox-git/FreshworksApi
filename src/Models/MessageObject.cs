using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkModels
{
    public class MessageObject: ErrorObject
    {
        [JsonProperty("message")]
        public string Message { get; set; } = null;
    }
}
