using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class ContactObject : ErrorObject
    {
        [JsonProperty("contact")]
        public ContactModel Contact { get; set; } = null;
    }
}
 