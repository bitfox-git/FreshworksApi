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
    [EndpointName("contact_statuses")]
    public class ContactStatuses: ISelector
    {
        [JsonProperty("contact_statuses")]
        public List<ContactStatusSelectionResponse> Statuses { get; set; }
    }
}
