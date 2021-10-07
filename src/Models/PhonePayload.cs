using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public class PhonePayload : ErrorObject
    {
        [JsonProperty("phone_call")]
        public PhoneModel Call { get; set; } = null;



    }
}
