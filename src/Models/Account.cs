using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Endpoints;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    [EndpointName("/api/sales_accounts")]
    public class Account: Includes, IHasInsert, IHasUpdate, IHasClone, IHasView, IHasAllView, IHasFileAndLinks, IHasDelete, IHasDeleteBulk, IHasForget, IHasFields, IHasFilters, IHasFilteredSearch, IHasUniqueID
    {
        [IsRequiredOn(nameof(IHasDelete))]
        [JsonProperty("selected_ids")]
        public List<long> SelectedIDs { get; set; } = null;

        [IsRequiredOn(nameof(IHasDelete))]
        [JsonProperty("delete_associated_contacts_deals")]
        public bool? DeleteAssociatedContactDeals { get; set; } = null;

        
        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;

        
        [JsonProperty("field_groups")]
        public List<Field> FieldGroup { get; set; } = null;

        
        [JsonProperty("fields")]
        public List<Field> Fields { get; set; } = null;

        
        [JsonProperty("message")]
        public string Message { get; set; } = null;

        
        [JsonProperty("filters")]
        public List<Filter> Filters { get; set; } = null;


        [JsonProperty("documents")]
        public List<File> Files { get; set; } = null;


        [JsonProperty("document_links")]
        public List<FileLink> FileLinks { get; set; } = null;


        [JsonProperty("document_associations")]
        public List<FileAssociation> FileAssociations { get; set; } = null;

        [IsRequiredOn(nameof(IHasUpdate))]
        [IsRequiredOn(nameof(IHasClone))]
        [IsRequiredOn(nameof(IHasDelete))]
        [IsRequiredOn(nameof(IHasForget))]
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [IsRequiredOn(nameof(IHasUpdate))]
        [IsRequiredOn(nameof(IHasClone))]
        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [JsonProperty("owner_id")]
        public long? OwnerID { get; set; } = null;

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

        [JsonProperty("business_type_id")]
        public long? BusinessTypeID { get; set; } = null;
        
        [JsonProperty("sales_activity_entity_types")]
        public List<Sale> SalesActivityEntityTypes { get; set; } = null;

        [JsonProperty("is_primary")]
        public bool? IsPrimary { get; set; } = null;

        [JsonProperty("number_of_employees")]
        public int? NumberOfEmployees { get; set; } = null;

        [JsonProperty("annual_revenue")]
        public int? AnnualRevenue { get; set; } = null;

        [JsonProperty("website")]
        public string Website { get; set; } = null;

        [JsonProperty("phone")]
        public string Phone { get; set; } = null;

        [JsonProperty("facebook")]
        public string Facebook { get; set; } = null;

        [JsonProperty("twitter")]
        public string Twitter { get; set; } = null;

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; } = null;

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

        [JsonProperty("partial")]
        public bool? Partial { get; set; } = null;

        [JsonProperty("team_user_ids")]
        public object TeamUserIDs { get; set; } = null;

        [JsonProperty("has_connections")]
        public bool? HasConnections { get; set; } = null;

        [JsonProperty("custom_field")]
        public JObject CustomField { get; set; } = null;

        [JsonProperty("error_code")]
        public int? ErrorCode { get; set; } = null;
    }
}
