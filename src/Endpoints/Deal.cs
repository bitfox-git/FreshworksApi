using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using Bitfox.Freshworks.NetworkObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints.Deals
{

    [EndpointName("/api/deals")]
    public class Deal: Includes, IHasInsert<Deal>, IHasUpdate, IHasClone, IHasView, IHasDelete, IHasDeleteBulk, IHasForget, IHasFields, IHasFilters, IHasUniqueID
    {
        [JsonParentProperty]
        [JsonProperty("deal")]
        public Deal Item { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("field_groups")]
        public List<Field> FieldGroup { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("fields")]
        public List<Field> Fields { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("message")]
        public string Message { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("selected_ids")]
        public List<long> SelectedIDs { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("delete_associated_contacts_deals")]
        public bool? DeleteAssociatedContactsDeals { get; set; } = null;

        // Childs

        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("amount")]
        public string Amount { get; set; } = null;

        [JsonProperty("base_currency_amount")]
        public string BaseCurrencyAmount { get; set; } = null;

        [JsonProperty("currency_id")]
        public long? CurrencyID { get; set; } = null;

        [JsonProperty("expected_close")]
        public object ExpectedClose { get; set; } = null;

        [JsonProperty("closed_date")]
        public object ClosedDate { get; set; } = null;

        [JsonProperty("stage_updated_time")]
        public DateTime? StageUpdatedTime { get; set; } = null;

        [JsonProperty("probability")]
        public int? Probability { get; set; } = null;

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        [JsonProperty("deal_pipeline_id")]
        public long? DealPipelineID { get; set; } = null;

        [JsonProperty("deal_stage_id")]
        public long? DealStageID { get; set; } = null;

        [JsonProperty("age")]
        public int? Age { get; set; } = null;

        [JsonProperty("recent_note")]
        public object RecentNote { get; set; } = null;

        [JsonProperty("completed_sales_sequences")]
        public object CompletedSalesSequences { get; set; } = null;

        [JsonProperty("active_sales_sequences")]
        public object ActiveSalesSequences { get; set; } = null;

        [JsonProperty("web_form_id")]
        public object WebFormID { get; set; } = null;

        [JsonProperty("upcoming_activities_time")]
        public object UpcomingActivitiesTime { get; set; } = null;

        [JsonProperty("last_assigned_at")]
        public DateTime? LastAssignedAt { get; set; } = null;

        [JsonProperty("tags")]
        public List<string> Tags { get; set; } = null;

        [JsonProperty("last_contacted_sales_activity_mode")]
        public object LastContactedSalesActivityMode { get; set; } = null;

        [JsonProperty("last_contacted_via_sales_activity")]
        public object LastContactedViaSalesActivity { get; set; } = null;

        [JsonProperty("expected_deal_value")]
        public string ExpectedDealValue { get; set; } = null;

        [JsonProperty("is_deleted")]
        public bool? IsDeleted { get; set; } = null;

        [JsonProperty("team_user_ids")]
        public object TeamUserIDs { get; set; } = null;

        [JsonProperty("avatar")]
        public object Avatar { get; set; } = null;

        [JsonProperty("fc_widget_collaboration")]
        public WidgetCredentials FCWidgetCollaboration { get; set; } = null;

        [JsonProperty("forecast_category")]
        public object ForecastCategory { get; set; } = null;

        [JsonProperty("rotten_days")]
        public object RottenDays { get; set; } = null;

        [JsonProperty("has_products")]
        public bool? HasProducts { get; set; } = null;

        [JsonProperty("products")]
        public object Products { get; set; } = null;

        [JsonProperty("links")]
        public Link Links { get; set; } = null;

        [JsonProperty("forecast_type")]
        public string ForecastType { get; set; } = null;

        [JsonProperty("choice_type")]
        public int? ChoiceType { get; set; } = null;

        [JsonProperty("probability")]
        public int? probability { get; set; } = null;

        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; } = null;

        [JsonProperty("rotting_days")]
        public int? RottingDays { get; set; } = null;

        [JsonProperty("configs")]
        public List<Config> Configs { get; set; } = null;

        [JsonProperty("aggregated_field")]
        public string AggregatedField { get; set; } = null;

        [JsonProperty("deal_stages")]
        public List<Deal> DealStages { get; set; } = null;

        [JsonProperty("is_null")]
        public bool? Isnull { get; set; } = null;


        private JObject CustomField { get; set; } = null;

        public T GetCustomFields<T>()
        {
            if (CustomField == null) return default;
            var job = CustomField;
            return job.ToObject<T>();
        }

        public void SetCustomFields<T>(T value)
        {
            CustomField = JObject.FromObject(value);
        }

    }




}
