
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Models
{
    public class SalesAccount
    {
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

        [JsonProperty("number_of_employees")]
        public int? NumberOfEmployees { get; set; } = null;

        [JsonProperty("annual_revenue")]
        public double? AnnualRevenue { get; set; } = null;

        [JsonProperty("website")]
        public string Website { get; set; } = null;

        [JsonProperty("owner_id")]
        public long? OwnerID { get; set; } = null;

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
        public string LastContactedMode { get; set;  }

        [JsonProperty("facebook")]
        public string Facebook { get; set; } = null;

        [JsonProperty("twitter")]
        public string Twitter { get; set; } = null;

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; } = null;

        [JsonProperty("parent_sales_account_id")]
        public long? ParentSalesAccountID {get;set; }

        [JsonProperty("create_at")]
        public DateTime? CreateAt { get; set; } = null;

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

        [JsonProperty("last_assigned_at")]
        public DateTime? LastAssignedAt { get; set; } = null;

        [JsonProperty("tags")]
        public List<string> Tags { get; set; } = null;

        [JsonProperty("is_deleted")]
        public bool? IsDeleted { get; set; } = null;


        [JsonProperty("custom_field")]
        public object CustomField { get; set; } = null;

        //public long team_user_ids { get; set; } = null;


        public T GetCustomFields<T>()
        {

            if (CustomField == null) return default(T);
            var job = (JObject)CustomField;
            return job.ToObject<T>();
        }

        public void SetCustomFields<T>(T value)
        {
            CustomField = JObject.FromObject(value);
        }

   

    }
}
