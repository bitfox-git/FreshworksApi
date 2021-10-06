using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkModels
{
    public class IndustryTypesObject : ErrorObject
    {
        [JsonProperty("industry_types")]
        public List<IndustryType> Types { get; set; } = null;
    }
}
