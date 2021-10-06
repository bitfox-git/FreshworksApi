using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkObjects
{
    public class AccountBulkDeleteObject
    {
        [JsonProperty("selected_ids")]
        public long[] SelectedIDs { get; set; } = null;


        [JsonProperty("delete_associated_contacts_deals")]
        public bool? DeleteAssociatedContactsDeals { get; set; } = null;
    }
}
