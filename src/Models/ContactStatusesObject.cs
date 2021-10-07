using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkModels
{
    public class ContactStatusesObject : ErrorObject
    {
        [JsonProperty("contact_statuses")]
        public List<ContactStatus> Statuses { get; set; } = null;
    }
}
