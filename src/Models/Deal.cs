using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{

    [EndpointName("/api/deals")]
    public class Deal: Includes, IHasInsert, IHasUpdate, IHasClone, IHasView, IHasAllView, IHasDelete, IHasDeleteBulk, IHasForget, IHasFields, IHasFilters, IHasFilteredSearch, IHasUniqueID
    {
        
        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;

        
        [JsonProperty("filters")]
        public List<Filter> Filters { get; set; } = null;

        
        [JsonProperty("field_groups")]
        public List<Field> FieldGroup { get; set; } = null;

        
        [JsonProperty("fields")]
        public List<Field> Fields { get; set; } = null;

        
        [JsonProperty("message")]
        public string Message { get; set; } = null;

        
        [JsonProperty("selected_ids")]
        public List<long> SelectedIDs { get; set; } = null;

        
        [JsonProperty("delete_associated_contacts_deals")]
        public bool? DeleteAssociatedContactDeals { get; set; } = null;

        
        [JsonProperty("error_code")]
        public int? ErrorCode { get; set; } = null;

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

        [JsonProperty("partial")]
        public bool? Partial { get; set; } = null;

        [JsonProperty("position")]
        public int? Position { get; set; } = null;

        [JsonProperty("value")]
        public string Value { get; set; } = null;

        [JsonProperty("custom_field")]
        public JObject CustomField { get; set; } = null;

        [JsonProperty("collaboration")]
        public object Collaboration { get; set; } = null;

        [JsonProperty("deal_prediction_last_updated_at")]
        public DateTime? DealPredictionLastUpdateAt { get; set; } = null;


        public void CatchInsertExceptions()
        {
            List<string> exceptions = new();

            if (Name == null)
            {
                exceptions.Add("Required key `Name` is missing.");
            }
            
            if (OwnerID == null)
            {
                exceptions.Add("Required key `OwnerID` is missing.");
            }
            
            if (Amount == null)
            {
                exceptions.Add("Required key `Amount` is missing.");
            }

            if (exceptions.Count > 0)
            {
                throw new MissingFieldException(string.Join("\n", exceptions));
            }
        }

        public void CatchUpdateExceptions()
        {
            List<string> exceptions = new();

            if (Name == null)
            {
                exceptions.Add("Required key `Name` is missing.");
            }
            
            if (ID == null)
            {
                exceptions.Add("Required key `ID` is missing.");
            }


            if (exceptions.Count > 0)
            {
                throw new MissingFieldException(string.Join("\n", exceptions));
            }
        }

        public void CatchCloneExceptions()
        {
            List<string> exceptions = new();

            if (Name == null)
            {
                exceptions.Add("Required key `Name` is missing.");
            }

            if (ID == null)
            {
                exceptions.Add("Required key `ID` is missing.");
            }


            if (exceptions.Count > 0)
            {
                throw new MissingFieldException(string.Join("\n", exceptions));
            }
        }

        public void CatchDeleteExceptions()
        {
            List<string> exceptions = new();

            if (ID == null)
            {
                exceptions.Add("Required key `ID` is missing.");
            }

            if (exceptions.Count > 0)
            {
                throw new MissingFieldException(string.Join("\n", exceptions));
            }
        }

        public void CatchForgetExceptions()
        {
            List<string> exceptions = new();

            if (ID == null)
            {
                exceptions.Add("Required key `ID` is missing.");
            }

            if (exceptions.Count > 0)
            {
                throw new MissingFieldException(string.Join("\n", exceptions));
            }
        }

        public void CatchDeleteBulkExceptions()
        {
            List<string> exceptions = new();

            if (SelectedIDs == null)
            {
                exceptions.Add("Required key `SelectedIDs` is missing.");
            }

            if (DeleteAssociatedContactDeals == null)
            {
                exceptions.Add("Required key `DeleteAssociatedContactDeals` is missing.");
            }

            if (exceptions.Count > 0)
            {
                throw new MissingFieldException(string.Join("\n", exceptions));
            }
        }
    
    }
}
