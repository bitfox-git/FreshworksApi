using Bitfox.Freshworks.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    [EndpointName("/api/filtered_search")]
    public class SearchFilter
    {
        [JsonProperty("filter_rule")]
        public List<FilterRule> FilterRules { get; set; }

        [JsonProperty("contacts")]
        public List<Contact> Contacts { get; set; }

        [JsonProperty("sales_account")]
        public List<Account> SalesAccount { get; set; }

        [JsonProperty("deal")]
        public List<Deal> Deals { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;
    }
}
