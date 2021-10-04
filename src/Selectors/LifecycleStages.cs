using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Selectors
{
    [EndpointName("lifecycle_stages")]
    public class LifecycleStages: ISelector
    {
        [JsonProperty("lifecycle_stages")]
        public List<LifecycleStageSelectionResponse> Stages { get; set; }
    }
}
