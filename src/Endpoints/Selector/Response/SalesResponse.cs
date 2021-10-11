using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints.Selector.Response
{
    public class SalesResponse: BaseResponse
    {
        [JsonProperty("sales_activity_types")]
        public List<SaleItem> SalesTypes { get; set; } = null;

        [JsonProperty("sales_activity_entity_types")]
        public List<SaleItem> SalesEntityTypes { get; set; } = null;

        [JsonProperty("sales_activity_outcomes")]
        public List<SaleItem> OutcomesTypes { get; set; } = null;
    }
}
