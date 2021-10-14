using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkModels
{
    public class ErrorObject: IErrors
    {
        [JsonProperty("errors")]
        public Errors Error { get; set; } = null;
    }
}
