using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkModels
{
    public class CurrenciesObject : ErrorObject
    {
        [JsonProperty("currencies")]
        public List<Currency> Currencies { get; set; } = null;
    }
}
