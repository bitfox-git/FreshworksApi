using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints.Selector
{
    public class SaleItem : UserItem
    {
        [JsonProperty("internal_name")]
        public string InternalName { get; set; } = null;

        [JsonProperty("show_in_conversation")]
        public bool? ShowInConversation { get; set; } = null;

        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; } = null;

        [JsonProperty("is_checkedin")]
        public bool? IsCheckedin { get; set; } = null;

        [JsonProperty("sales_activity_type_name")]
        public string SalesActivityTypeName { get; set; } = null;

        [JsonProperty("sales_activity_type_id")]
        public long? SalesActivityTypeID { get; set; } = null;

    }
}
