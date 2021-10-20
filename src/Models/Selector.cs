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
        [JsonReturnParentProperty]
        [JsonProperty("business_types")]
        public List<User> BusinessTypes { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("campaigns")]
        public List<User> Campaigns { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("contact_statuses")]
        public List<ContactStatus> Statuses { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("users")]
        public List<User> Users { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("industry_types")]
        public List<User> IndustryTypes { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("lifecycle_stages")]
        public List<StageLifecycle> Stages { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("territories")]
        public List<User> Territories { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("currencies")]
        public List<Currency> Currencies { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("sales_activity_types")]
        public List<Sale> SalesTypes { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("sales_activity_entity_types")]
        public List<Sale> SalesEntityTypes { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("sales_activity_outcomes")]
        public List<Sale> OutcomesTypes { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("deal_products")]
        public List<Deal> DealProducts { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("deal_stages")]
        public List<Deal> DealStages { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("deal_types")]
        public List<Deal> DealTypes { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("deal_reasons")]
        public List<Deal> DealReasons { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("deal_payment_statuses")]
        public List<Deal> PaymentStatuses { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("deal_pipelines")]
        public List<Deal> DealPipelines { get; set; } = null;
    }
}