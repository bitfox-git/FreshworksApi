﻿using Bitfox.Freshworks.Attributes;
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
    [EndpointName("/api/contacts")]
    public class Contact : Includes, IHasInsert, IHasUpdate, IHasClone, IHasView, IHasAllView, IHasFileAndLinks, IHasDelete, IHasAssignBulk, IHasDeleteBulk, IHasForget, IHasFields, IHasActivities, IHasFilters, IHasFilteredSearch, IHasUniqueID
    {

        [JsonProperty("activities")]
        public List<Activity> Activities { get; set; } = null;


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

        [IsRequiredOn(nameof(IHasAssignBulk))]
        [IsRequiredOn(nameof(IHasDeleteBulk))]
        [JsonProperty("selected_ids")]
        public List<long> SelectedIDs { get; set; } = null;

        [JsonProperty("outcomes")]
        public List<Outcome> Outcomes { get; set; } = null;

        // Childs
        [IsRequiredOn(nameof(IHasUpdate))]
        [IsRequiredOn(nameof(IHasClone))]
        [IsRequiredOn(nameof(IHasDelete))]
        [IsRequiredOn(nameof(IHasForget))]
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [IsRequiredOn(nameof(IHasAssignBulk))]
        [JsonProperty("owner_id")]
        public long? OwnerID { get; set; } = null;

        [IsRequiredOn(nameof(IHasUpdate))]
        [IsRequiredOn(nameof(IHasClone))]
        [JsonProperty("first_name")]
        public string FirstName { get; set; } = null;

        [JsonProperty("last_name")]
        public string LastName { get; set; } = null;

        [JsonProperty("display_name")]
        public string DisplayName { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("position")]
        public int? Position { get; set; } = null;

        [JsonProperty("forecast_type")]
        public string ForecastType { get; set; } = null;

        [JsonProperty("sales_activity_entity_types")]
        public List<Sale> SalesActivityEntityTypes { get; set; } = null;

        [JsonProperty("avatar")]
        public string Avatar { get; set; } = null;

        [JsonProperty("job_title")]
        public string JobTitle { get; set; } = null;

        [JsonProperty("city")]
        public string City { get; set; } = null;

        [JsonProperty("state")]
        public string State { get; set; } = null;

        [JsonProperty("zipcode")]
        public string ZipCode { get; set; } = null;

        [JsonProperty("country")]
        public string Country { get; set; } = null;

        [IsRequiredOn(nameof(IHasInsert))]
        [IsRequiredOn(nameof(IHasClone))]
        [JsonProperty("email")]
        public string Email { get; set; } = null;

        [JsonProperty("emails")]
        public List<Email> Emails { get; set; } = null;

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; } = null;

        [JsonProperty("work_number")]
        public string WorkNumber { get; set; } = null;

        [JsonProperty("mobile_number")]
        public string MobileNumber { get; set; } = null;

        [JsonProperty("address")]
        public string Address { get; set; } = null;

        [JsonProperty("last_seen")]
        public string LastSeen { get; set; } = null;

        [JsonProperty("lead_score")]
        public int? LeadScore { get; set; } = null;

        [JsonProperty("last_contacted")]
        public string LastContacted { get; set; } = null;

        [JsonProperty("open_deals_amount")]
        public string OpenDealsAmount { get; set; } = null;

        [JsonProperty("won_deals_amount")]
        public string WonDealsAmount { get; set; } = null;

        [JsonProperty("links")]
        public Link Links { get; set; } = null;

        [JsonProperty("last_contacted_sales_activity_mode")]
        public string LastContactedSalesActivityMode { get; set; } = null;

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; } = null;

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; } = null;

        [JsonProperty("keyword")]
        public string Keyword { get; set; } = null;

        [JsonProperty("medium")]
        public string Medium { get; set; } = null;

        [JsonProperty("last_contacted_mode")]
        public string LastContactedMode { get; set; } = null;

        [JsonProperty("recent_note")]
        public string RecentNote { get; set; } = null;

        [JsonProperty("won_deals_count")]
        public int? WonDealsCount { get; set; } = null;

        [JsonProperty("last_contacted_via_sales_activity")]
        public string LastContactedViaSalesActivity { get; set; } = null;

        [JsonProperty("completed_sales_sequences")]
        public string CompletedSalesSequences { get; set; } = null;

        [JsonProperty("active_sales_sequences")]
        public string ActiveSalesSequences { get; set; } = null;

        [JsonProperty("web_form_ids")]
        public string WebFormIDs { get; set; } = null;

        [JsonProperty("open_deals_count")]
        public int? OpenDealsCount { get; set; } = null;

        [JsonProperty("last_assigned_at")]
        public string LastAssignedAt { get; set; } = null;

        [JsonProperty("tags")]
        public List<string> Tags { get; set; } = null;

        [JsonProperty("is_deleted")]
        public bool? IsDeleted { get; set; } = null;

        [JsonProperty("team_user_ids")]
        public string TeamUserIDs { get; set; } = null;

        [JsonProperty("external_id")]
        public string ExternalID { get; set; } = null;

        [JsonProperty("work_email")]
        public string WorkEmail { get; set; } = null;

        /// <summary>
        /// list of integers, seperated by semicolon
        /// for example: 3;4;1
        /// </summary>
        [JsonProperty("subscription_status")]
        public string SubscriptionStatus { get; set; } = null;

        [JsonProperty("customer_fit")]
        public int? CustomerFit { get; set; } = null;

        [JsonProperty("whatsapp_subscription_status")]
        public int? WhatsappSubscriptionStatus { get; set; } = null;

        [JsonProperty("phone_numbers")]
        public List<Phone> PhoneNumbers { get; set; } = null;

        [JsonProperty("facebook")]
        public string Facebook { get; set; } = null;

        [JsonProperty("twitter")]
        public string Twitter { get; set; } = null;

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; } = null;

        /// <summary>
        /// list of integers, seperated by semicolon
        /// for example: 3;4;1
        /// </summary>
        [JsonProperty("subscription_types")]
        public string SubscriptionTypes { get; set; } = null;

        [JsonProperty("list_ids")]
        public long[] ListIDs { get; set; } = null;

        [JsonProperty("has_duplicates")]
        public bool? HasDuplicates { get; set; } = null;

        [JsonProperty("duplicates_searched_today")]
        public bool? DuplicatesSearchedToday { get; set; } = null;

        [JsonProperty("has_connections")]
        public bool? HasConnections { get; set; } = null;

        [JsonProperty("connections_searched_today")]
        public bool? ConnectionsSearchedToday { get; set; } = null;

        [JsonProperty("partial")]
        public bool? Partial { get; set; } = null;

        [JsonProperty("lifecycle_stage_id")]
        public long? LifecycleStageID { get; set; } = null;

        [JsonProperty("custom_field")]
        public JObject CustomField { get; set; } = null;

        [JsonProperty("delete_associated_contacts_deals")]
        public bool? DeleteAssociatedContactDeals { get; set; } = null;

    }
}
