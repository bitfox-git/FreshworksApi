using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkModels
{
    public class ContactsObject : ErrorObject
    {
        [JsonProperty("contacts")]
        public List<ContactModel> Contacts { get; set; } = null;
    }
}
