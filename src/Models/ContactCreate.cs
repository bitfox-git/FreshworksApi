using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    class ContactCreate
    {
        [JsonProperty("contact")]
        public ContactModel Contact { get; set; } = null;
    }
}
