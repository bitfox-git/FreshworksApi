using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Bitfox.Freshworks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bitfox.Freshworks.Models
{
    [EndpointName("/api/selector")]
    public class Selector: Includes
    {
        
        [JsonProperty("contact_statuses")]
        public List<Contact> Statuses { get; set; } = null;

        
        [JsonProperty("lifecycle_stages")]
        public List<StageLifecycle> Stages { get; set; } = null;

        
        [JsonProperty("currencies")]
        public List<Currency> Currencies { get; set; } = null;

        
        [JsonProperty("sales_activity_types")]
        public List<Sale> SalesTypes { get; set; } = null;

        
        [JsonProperty("sales_activity_entity_types")]
        public List<Sale> SalesEntityTypes { get; set; } = null;

        
        [JsonProperty("sales_activity_outcomes")]
        public List<Sale> OutcomesTypes { get; set; } = null;

        
        [JsonProperty("deal_products")]
        public List<Deal> DealProducts { get; set; } = null;

        
        [JsonProperty("deal_stages")]
        public List<Deal> DealStages { get; set; } = null;

        
        [JsonProperty("deal_types")]
        public List<Deal> DealTypes { get; set; } = null;

        
        [JsonProperty("deal_reasons")]
        public List<Deal> DealReasons { get; set; } = null;

        
        [JsonProperty("deal_payment_statuses")]
        public List<Deal> PaymentStatuses { get; set; } = null;

        
        [JsonProperty("deal_pipelines")]
        public List<Deal> DealPipelines { get; set; } = null;
    }
}