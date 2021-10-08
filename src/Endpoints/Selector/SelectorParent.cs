using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bitfox.Freshworks.Models
{
    public class SelectorParent: ErrorObject, IIncludes
    {
        [JsonProperty("users")]
        public List<User> Users { get; set; } = null;


        [JsonProperty("currencies")]
        public List<SelectorModel> Currencies { get; set; } = null;


        [JsonProperty("contact_statuses")]
        public List<SelectorModel> Statuses { get; set; } = null;


        [JsonProperty("deal_stages")]
        public List<SelectorModel> DealStages { get; set; } = null;


        [JsonProperty("lifecycle_stages")]
        public List<SelectorModel> LifecycleStages { get; set; } = null;


        [JsonProperty("deal_types")]
        public List<SelectorModel> DealTypes { get; set; } = null;


        [JsonProperty("deal_reasons")]
        public List<SelectorModel> DealReasons { get; set; } = null;


        [JsonProperty("deal_pipelines")]
        public List<SelectorModel> DealPipelines { get; set; } = null;


        [JsonProperty("deal_payment_statuses")]
        public List<SelectorModel> PaymentStatuses { get; set; } = null;


        [JsonProperty("business_types")]
        public List<SelectorModel> BusinessTypes { get; set; } = null;


        [JsonProperty("industry_types")]
        public List<SelectorModel> IndustryTypes { get; set; } = null;


        [JsonProperty("sales_activity_types")]
        public List<SelectorModel> SalesTypes { get; set; } = null;


        [JsonProperty("sales_activity_entity_types")]
        public List<SelectorModel> SalesEntityTypes { get; set; } = null;


        [JsonProperty("sales_activity_outcomes")]
        public List<SelectorModel> OutcomesTypes { get; set; } = null;

        public IncludesObject Includes { get; set; } = null;
    }
}
