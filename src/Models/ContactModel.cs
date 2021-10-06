﻿using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Models
{
    public class ContactModel : ContactObjects
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("first_name")]
        public string FirstName { get; set; } = null;

        [JsonProperty("last_name")]
        public string LastName { get; set; } = null;

        [JsonProperty("display_name")]
        public string DisplayName { get; set; } = null;

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

        [JsonProperty("email")]
        public string Email { get; set; } = null;

        [JsonProperty("emails")]
        public List<EmailModel> Emails { get; set; } = null;

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
        public LinkModel Links { get; set; } = null;

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

        [JsonProperty("subscription_status")]
        public int? SubscriptionStatus { get; set; } = null;

        [JsonProperty("customer_fit")]
        public int? CustomerFit { get; set; } = null;

        [JsonProperty("whatsapp_subscription_status")]
        public int? WhatsappSubscriptionStatus { get; set; } = null;

        [JsonProperty("phone_numbers")]
        public List<string> PhoneNumbers { get; set; } = null;

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


        /// TODO : should be private field + detect deserialization state? (null vs empty)?


        /// <summary>
        /// list of listids, but only filled when ?include=list?
        /// </summary>

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

        [JsonProperty("sales_accounts")]
        public List<ContactSalesAccountPartial> SalesAccounts { get; set; } = null;

        [JsonProperty("lifecycle_stage_id")]
        public long? LifecycleStageID { get; set; } = null;


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// 


        //[JsonProperty("custom_field")]
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
