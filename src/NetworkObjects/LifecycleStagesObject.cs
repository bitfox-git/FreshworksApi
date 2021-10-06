using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkModels
{
    public class LifecycleStagesObject : ErrorObject
    {
        [JsonProperty("lifecycle_stages")]
        public List<LifecycleStage> Stages { get; set; } = null;
    }
}
