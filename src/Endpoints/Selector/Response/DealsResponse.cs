using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints.Selector.Response
{
    public class DealsResponse: BaseResponse
    {

        [JsonProperty("deal_products")]
        public List<DealItem> DealProducts { get; set; } = null;

        [JsonProperty("deal_stages")]
        public List<DealItem> DealStages { get; set; } = null;

        [JsonProperty("deal_types")]
        public List<DealItem> DealTypes { get; set; } = null;

        [JsonProperty("deal_reasons")]
        public List<DealItem> DealReasons { get; set; } = null;

        [JsonProperty("deal_payment_statuses")]
        public List<DealItem> PaymentStatuses { get; set; } = null;

        [JsonProperty("deal_pipelines")]
        public List<DealItem> DealPipelines { get; set; } = null;

    }
}
