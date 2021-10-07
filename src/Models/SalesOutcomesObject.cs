using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkObjects
{
    public class SalesOutcomesObject : ErrorObject
    {
        [JsonProperty("sales_activity_outcomes")]
        public List<SalesActivityType> Types { get; set; } = null;
    }
}
