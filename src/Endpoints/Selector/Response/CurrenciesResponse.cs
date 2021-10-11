
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
    public class UsersResponse : BaseResponse
    {
        [JsonProperty("users")]
        public List<User> Campaigns { get; set; } = null;
    }
}
