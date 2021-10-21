using Bitfox.Freshworks.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    [EndpointName("/api/search")]
    public class Search : Includes
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("stage_name")]
        public string StageName { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("email")]
        public string Email { get; set; } = null;

        [JsonProperty("owner")]
        public User Owner { get; set; } = null;

        [JsonProperty("country")]
        public string Country { get; set; } = null;

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

        [JsonProperty("avatar")]
        public string Avatar { get; set; } = null;

        [JsonProperty("sales_account_name")]
        public string SalesAccountName { get; set; } = null;

        [JsonProperty("primary_sales_account_name")]
        public string PrimarySalesAccountName { get; set; } = null;

        [JsonProperty("type")]
        public string Type { get; set; } = null;

    }
}
