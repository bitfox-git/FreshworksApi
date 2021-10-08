using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkObjects
{
    public class WidgetCollaborationObject
    {
        [JsonProperty("convo_token")]
        public string ConvoToken { get; set; } = null;

        [JsonProperty("auth_token")]
        public string AuthToken { get; set; } = null;

        [JsonProperty("encoded_jwt_token")]
        public string EncodedJWTtoken { get; set; } = null;
    }
}
