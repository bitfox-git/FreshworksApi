using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints.Contact
{
    public interface IContactPayload
    {
        [JsonProperty("contact")]
        ContactModel Contact { get; set; }
    }
}
