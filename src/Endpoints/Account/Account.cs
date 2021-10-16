using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.NetworkModels;
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
    [EndpointName("/api/sales_accounts")]
    public class Account: IHasInsert, IHasUpdate, IHasClone, IHasView, IHasDelete, IHasDeleteBulk, IHasForget, IHasFields, IHasFilters, IHasUniqueID                //, IHasUniqueID, IIncludes, IResult
    {
        [JsonParentProperty]
        [JsonProperty("sales_account")]
        public Account Content { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("sales_accounts")]
        public List<Account> Accounts { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("selected_ids")]
        public List<long> SelectedIDs { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("delete_associated_contacts_deals")]
        public bool? DeleteAssociatedContactsDeals { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("field_groups")]
        public List<FieldGroup> FieldGroup { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("fields")]
        public List<Field> Fields { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("message")]
        public string Message { get; set; } = null;

        [JsonParentProperty]
        [JsonProperty("filters")]
        public List<Filter> Filters { get; set; } = null;























        /// <summary>
        ///  Content data below
        /// </summary>


        [JsonProperty("id")]
        public long? ID { get; set; } = null;

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

        [JsonProperty("industry_type_id")]
        public long? IndustryTypeID { get; set; } = null;

        [JsonProperty("business_type_id")]
        public long? BusinessTypeID { get; set; } = null;

        [JsonProperty("number_of_employees")]
        public int? NumberOfEmployees { get; set; } = null;

        [JsonProperty("annual_revenue")]
        public int? AnnualRevenue { get; set; } = null;

        [JsonProperty("website")]
        public string Website { get; set; } = null;

        [JsonProperty("phone")]
        public string Phone { get; set; } = null;

        [JsonProperty("owner_id")]
        public long? OwnerID { get; set; } = null;

        [JsonProperty("facebook")]
        public string Facebook { get; set; } = null;

        [JsonProperty("twitter")]
        public string Twitter { get; set; } = null;

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; } = null;

        [JsonProperty("territory_id")]
        public long? TerritoryID { get; set; } = null;

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; } = null;

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; } = null;

        [JsonProperty("parent_sales_account_id")]
        public long? ParentSalesAccountID { get; set; } = null;

        [JsonProperty("open_deals_amount")]
        public object OpenDealsAmount { get; set; } = null;

        [JsonProperty("open_deals_count")]
        public int? OpenDealsCount { get; set; } = null;

        [JsonProperty("won_deals_amount")]
        public object WonDealsAmount { get; set; } = null;

        [JsonProperty("won_deals_count")]
        public int? WonDealsCount { get; set; } = null;

        [JsonProperty("last_contacted")]
        public object LastContacted { get; set; } = null;

        [JsonProperty("last_contacted_mode")]
        public object LastContactedMode { get; set; } = null;

        [JsonProperty("links")]
        public Link Links { get; set; } = null;

        [JsonProperty("avatar")]
        public object Avatar { get; set; } = null;

        [JsonProperty("recent_note")]
        public object RecentNote { get; set; } = null;

        [JsonProperty("last_contacted_via_sales_activity")]
        public object LastContactedViaSalesActivity { get; set; } = null;

        [JsonProperty("last_contacted_sales_activity_mode")]
        public object LastContactedSalesActivityMode { get; set; } = null;

        [JsonProperty("completed_sales_sequences")]
        public object CompletedSalesSequences { get; set; } = null;

        [JsonProperty("active_sales_sequences")]
        public object ActiveSalesSequences { get; set; } = null;

        [JsonProperty("last_assigned_at")]
        public object LastAssignedAt { get; set; } = null;

        [JsonProperty("tags")]
        public object[] Tags { get; set; } = null;

        [JsonProperty("is_deleted")]
        public bool? IsDeleted { get; set; } = null;

        [JsonProperty("team_user_ids")]
        public object TeamUserIDs { get; set; } = null;

        [JsonProperty("has_connections")]
        public bool? HasConnections { get; set; } = null;

        [JsonProperty("custom_field")]
        private JObject CustomField { get; set; } = null;

        public T GetCustomFields<T>()
        {
            if (CustomField == null) return default;
            var job = (JObject)CustomField;
            return job.ToObject<T>();
        }

        public void SetCustomFields<T>(T value)
        {
            CustomField = JObject.FromObject(value);
        }

    }
}
