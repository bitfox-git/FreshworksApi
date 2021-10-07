using Bitfox.Freshworks.NetworkObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class DealModel: DealParent
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("amount")]
        public string Amount { get; set; } = null;

        [JsonProperty("base_currency_amount")]
        public string BaseCurrencyAmount { get; set; } = null;

        [JsonProperty("owner_id")]
        public long? OwnerID { get; set; } = null;

        [JsonProperty("currency_id")]
        public long? CurrencyID { get; set; } = null;

        [JsonProperty("sales_account_id")]
        public long? SalesAccountID { get; set; } = null;

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
        public WidgetCollaborationObject FCWidgetCollaboration { get; set; } = null;

        [JsonProperty("forecast_category")]
        public object ForecastCategory { get; set; } = null;

        [JsonProperty("rotten_days")]
        public object RottenDays { get; set; } = null;

        [JsonProperty("has_products")]
        public bool? HasProducts { get; set; } = null;

        [JsonProperty("products")]
        public object Products { get; set; } = null;

        [JsonProperty("creater_id")]
        public long? CreaterID { get; set; } = null;

        [JsonProperty("links")]
        public LinkModel Links { get; set; } = null;

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
