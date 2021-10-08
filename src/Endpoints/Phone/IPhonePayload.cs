using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface IPhonePayload
    {
        [JsonProperty("phone_call")]
        PhoneModel Call { get; set; }
    }
}
