using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkModels
{
    public class ActivitiesObject : ErrorObject
    {
        [JsonProperty("activities")]
        public ActivityObject[] Activities { get; set; } = null;
    }
}
