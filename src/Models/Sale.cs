using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints.Sales
{
    [EndpointName("/api/sales_activities")]
    public class Sale : Includes, IHasInsert, IHasView, IHasUpdate, IHasDelete, IHasFilters, IHasUniqueID
    {
        [JsonReturnParentProperty]
        [JsonProperty("sales_activity")]
        public Sale Item { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("sales_activities")]
        public List<Sale> Activities { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;


        // Childs
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("title")]
        public string Title { get; set; } = null;

        [JsonProperty("start_date")]
        public DateTime? StartDate { get; set; } = null;

        [JsonProperty("end_date")]
        public DateTime? EndDate { get; set; } = null;

        [JsonProperty("sales_activity_type_id")]
        public long? SalesActivityTypeID { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("address")]
        public string Address { get; set; } = null;

        [JsonProperty("city")]
        public string City { get; set; } = null;

        [JsonProperty("state")]
        public string State { get; set; } = null;

        [JsonProperty("zipcode")]
        public string ZipCode { get; set; } = null;

        [JsonProperty("country")]
        public string Country { get; set; } = null;

        [JsonProperty("number_of_employees")]
        public int? NumberOfEmployees { get; set; } = null;

        [JsonProperty("annual_revenue")]
        public double? AnnualRevenue { get; set; } = null;

        [JsonProperty("website")]
        public string Website { get; set; } = null;

        [JsonProperty("is_primary")]
        public bool? IsPrimary { get; set; } = null;

        [JsonProperty("phone")]
        public string Phone { get; set; } = null;

        [JsonProperty("open_deals_amount")]
        public double? OpenDealsAmount { get; set; } = null;

        [JsonProperty("open_deals_count")]
        public int? OpenDealsCount { get; set; } = null;

        [JsonProperty("won_deals_amount")]
        public double? WonDealsAmount { get; set; } = null;

        [JsonProperty("won_deals_count")]
        public int? WonDealsCount { get; set; } = null;

        [JsonProperty("last_contacted")]
        public DateTime? LastContacted { get; set; } = null;

        [JsonProperty("last_contacted_mode")]
        public string LastContactedMode { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; } = null;

        [JsonProperty("twitter")]
        public string Twitter { get; set; } = null;

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; } = null;

        [JsonProperty("parent_sales_account_id")]
        public long? ParentSalesAccountID { get; set; }

        [JsonProperty("create_at")]
        public DateTime? CreateAt { get; set; } = null;

        [JsonProperty("last_assigned_at")]
        public DateTime? LastAssignedAt { get; set; } = null;

        [JsonProperty("tags")]
        public List<string> Tags { get; set; } = null;

        [JsonProperty("is_deleted")]
        public bool? IsDeleted { get; set; } = null;


        [JsonProperty("custom_field")]
        public object CustomField { get; set; } = null;

        [JsonProperty("internal_name")]
        public string InternalName { get; set; } = null;

        [JsonProperty("show_in_conversation")]
        public bool? ShowInConversation { get; set; } = null;

        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; } = null;

        [JsonProperty("is_checkedin")]
        public bool? IsCheckedin { get; set; } = null;

        [JsonProperty("sales_activity_type_name")]
        public string SalesActivityTypeName { get; set; } = null;

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

        [JsonProperty("sales_activity_outcome_id")]
        public long? SalesActivityOutcomeID { get; set; } = null;

        [JsonProperty("remote_id")]
        public object RemoteID { get; set; } = null;

        [JsonProperty("import_id")]
        public object ImportID { get; set; } = null;

        [JsonProperty("conversation_time")]
        public DateTime? ConversationTime { get; set; } = null;

        [JsonProperty("targetable_id")]
        public long? TargetableID { get; set; } = null;

        [JsonProperty("targetable_type")]
        public string TargetableType { get; set; } = null;

        [JsonProperty("latitude")]
        public string Latitude { get; set; } = null;

        [JsonProperty("longitude")]
        public string Longitude { get; set; } = null;

        [JsonProperty("location")]
        public string Location { get; set; } = null;

        [JsonProperty("checkedin_at")]
        public DateTime? CheckedinAt { get; set; } = null;

        [JsonProperty("success")]
        public string Success { get; set; } = null;

        [JsonProperty("partial")]
        public bool? Partial { get; set; } = null;

        [JsonProperty("position")]
        public int? Position { get; set; } = null;

        public void CatchDeleteExceptions()
        {
            throw new NotImplementedException();
        }

        public void CatchInsertExceptions()
        {
            List<string> exceptions = new();

            if (Title == null)
            {
                exceptions.Add("Required key `Title` is missing.");
            }

            if (StartDate == null)
            {
                exceptions.Add("Required key `StartDate` is missing.");
            }

            if (EndDate == null)
            {
                exceptions.Add("Required key `EndDate` is missing.");
            }

            if (SalesActivityTypeID == null)
            {
                exceptions.Add("Required key `SalesActivityTypeID` is missing.");
            }

            if (Notes == null)
            {
                exceptions.Add("Required key `Notes` is missing.");
            }

            if (TargetableID == null)
            {
                exceptions.Add("Required key `TargetableID` is missing.");
            }

            if (TargetableType == null)
            {
                exceptions.Add("Required key `TargetableType` is missing.");
            }

            if (exceptions.Count > 0)
            {
                throw new MissingFieldException(string.Join("\n", exceptions));
            }
        }

        public void CatchUpdateExceptions()
        {
            throw new NotImplementedException();
        }


    }
}
