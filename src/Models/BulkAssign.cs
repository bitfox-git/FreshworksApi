using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkModels
{
    public class BulkAssign
    {
        [JsonProperty("selected_ids")]
        public long[] SelectedIDs { get; set; } = null;

        [JsonProperty("owner_id")]
        public long? OwnerID { get; set; } = null;

    }
}
