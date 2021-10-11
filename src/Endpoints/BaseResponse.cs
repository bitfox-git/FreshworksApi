using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public class BaseResponse: IIncludes
    {
        [JsonProperty("errors")]
        Error Error { get; set; } = null;

        public Includes Includes { get; set; } = null;
    }
}
