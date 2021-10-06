using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkModels
{
    public class BusinessTypesObject : ErrorObject
    {
        [JsonProperty("business_types")]
        public List<BusinessType> Types { get; set; } = null;
    }
}
