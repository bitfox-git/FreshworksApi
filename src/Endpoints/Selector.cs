using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Endpoints.Deals;
using Bitfox.Freshworks.Endpoints.Sales;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints.Selector
{
    [EndpointName("/api/selector")]
    public class Selector
    {
        [JsonParentProperty]
        [JsonProperty("business_types")]
        public List<User> BusinessTypes { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("campaigns")]
        public List<User> Campaigns { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("contact_statuses")]
        public List<ContactStatus> Statuses { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("users")]
        public List<User> Users { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("industry_types")]
        public List<User> IndustryTypes { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("lifecycle_stages")]
        public List<StageLifecycle> Stages { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("territories")]
        public List<User> Territories { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("currencies")]
        public List<Currency> Currencies { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("sales_activity_types")]
        public List<Sale> SalesTypes { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("sales_activity_entity_types")]
        public List<Sale> SalesEntityTypes { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("sales_activity_outcomes")]
        public List<Sale> OutcomesTypes { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("deal_products")]
        public List<Deal> DealProducts { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("deal_stages")]
        public List<Deal> DealStages { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("deal_types")]
        public List<Deal> DealTypes { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("deal_reasons")]
        public List<Deal> DealReasons { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("deal_payment_statuses")]
        public List<Deal> PaymentStatuses { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("deal_pipelines")]
        public List<Deal> DealPipelines { get; set; } = null;
    }
}