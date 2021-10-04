using Bitfox.Freshworks.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Models
{



    [EndpointName("contacts")]
    [JsonPluralName("contacts")]
    [JsonSingularName("contact")]
    [Include("lists")]
    public class Contact : IUniqueID, IHasView
    {
        [JsonProperty("id")]
        public long ID { get; set; }
        
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        
        [JsonProperty("avatar")]
        public string Avatar { get; set; }
        
        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("city")]
        public string City  { get; set; }
        
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("email")]
        [Obsolete("Use the emails property instead.")]
        public string Email { get; set; }

        [JsonProperty("emails")]
        public List<ContactEmail> Emails { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("work_number")]
        public string WorkNumber { get; set; }

        [JsonProperty("mobile_number")]
        public string MobileNumber { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("last_seen")]
        public DateTime? LastSeen { get; set; }

        [JsonProperty("lead_score")]
        public int LeadScore { get; set; }

        [JsonProperty("last_contacted")]
        public DateTime? LastContacted { get; set; }

        [JsonProperty("open_deals_amount")]
        public double? OpenDealsAmount { get; set; }

        [JsonProperty("won_deals_amount")]
        public double? WonDealsAmount { get; set; }

        [JsonProperty("last_contacted_sales_activity_mode")]
        public string LastContactedSalesActivityMode { get; set; }

        [JsonProperty("custom_field")]
        public object CustomField { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        //[JsonIgnore()]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; private set; }

        //keyword": null??

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("last_contacted_mode")]
        public string LastContactedMode { get; set; }
        
        [JsonProperty("recent_note")]
        public string RecentNote{ get; }
        
        [JsonProperty("won_deals_count")]
        public int? WonDealsCount { get; set; }

        //"last_contacted_via_sales_activity": null,

        [JsonProperty("completed_sales_sequences")]
        public int? CompletedSalesSequences { get; set; }
        
        //"active_sales_sequences": null,
        
        //"web_form_ids": null,

        [JsonProperty("open_deals_count")]
        public int OpenDealsCount { get; set; }

        [JsonProperty("last_assigned_at")]
        public DateTime? LastAssignedAt { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        //"team_user_ids": null,

        [JsonProperty("external_id")]
        public string ExternalID { get; set; }

        [JsonProperty("work_email")]
        public string WorkEmail { get; set; }

        //TODO : make enum?

        [JsonProperty("subscription_status")]
        public int SubscriptionStatus { get; set; }

        /// <summary>
        /// list of integers, seperated by semicolon
        /// for example: 3;4;1
        /// </summary>
        [JsonProperty("subscription_types")]
        public string SubscriptionTypes { get; set; }


        /// TODO : should be private field + detect deserialization state? (null vs empty)?


        /// <summary>
        /// list of listids, but only filled when ?include=list?
        /// </summary>

        [JsonProperty("list_ids")]
        public long[] ListIDs { get; set; }

        [JsonProperty("customer_fit")]
        public int CustomerFit { get; set; }

        [JsonProperty("has_duplicates")]
        public bool HasDuplicates { get; set; }

        [JsonProperty("duplicates_searched_today")]
        public bool DuplicatesSearchedToday { get; set; }

        [JsonProperty("has_connections")]
        public bool HasConnections { get; set; }

        [JsonProperty("connections_searched_today")]
        public bool ConnectionsSearchedToday { get; set; }

        //public "phone_numbers": [],
        
        [JsonProperty("sales_accounts")]
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<ContactSalesAccountPartial> SalesAccounts { get; set; }

        [JsonProperty("lifecycle_stage_id")]
        public long LifecycleStageID { get; set; }

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
