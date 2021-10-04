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
    [EndpointName("currencies")]
    public class Currencies: ISelector
    {
        [JsonProperty("currencies")]
        public List<CurrencySelectionResponse> Valutas { get; set; }
    }
}
