
using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints.Selector.Response
{
    public class CurrenciesResponse : BaseResponse
    {
        [JsonProperty("currencies")]
        public List<Currency> Currencies { get; set; } = null;
    }
}
