using Bitfox.Freshworks.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Models
{
    // "id": 30001773156,
    //"name": "Widgetz.io (sample)",
    //"address": "160-6802 Aliquet Rd.",
    //"city": "New Haven",
    //"state": "Connecticut",
    //"zipcode": "68089",
    //"country": "United States",
    //"number_of_employees": null,
    //"annual_revenue": null,
    //"website": "widgetz.io",
    //"owner_id": 30000015422,
    //"phone": "5036153947",
    //"open_deals_amount": "0.0",
    //"open_deals_count": 0,
    //"won_deals_amount": "0.0",
    //"won_deals_count": 0,
    //"last_contacted": "2021-02-15T17:21:09+01:00",
    //"last_contacted_mode": "Email Opened",
    //"facebook": null,
    //"twitter": null,
    //"linkedin": null,
    //"links": { },
    //"custom_field": { },
    //"created_at": "2021-02-25T16:26:07+01:00",
    //"updated_at": "2021-03-29T12:16:06+02:00",
    //"avatar": null,
    //"parent_sales_account_id": null,
    //"recent_note": null,
    //"last_contacted_via_sales_activity": null,
    //"last_contacted_sales_activity_mode": null,
    //"completed_sales_sequences": null,
    //"active_sales_sequences": null,
    //"last_assigned_at": "2021-02-17T17:21:08+01:00",
    //"tags": [
    //    "depot",
    //    "website"
    //],
    //"is_deleted": false,
    //"team_user_ids": null


    [EndpointName("sales_accounts")]
    [JsonPluralName("sales_accounts")]
    [JsonSingularName("sales_account")]
    public class SalesAccount : IUniqueID, IHasView
    {
        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("number_of_employees")]
        public int? NumberOfEmployees { get; set; }

        [JsonProperty("annual_revenue")]
        public double? AnnualRevenue { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("owner_id")]
        public long? OwnerID { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("open_deals_amount")]
        public double? OpenDealsAmount { get; set; }

        [JsonProperty("open_deals_count")]
        public int? OpenDealsCount { get; set; }

        [JsonProperty("won_deals_amount")]
        public double? WonDealsAmount { get; set; }

        [JsonProperty("won_deals_count")]
        public int? WonDealsCount { get; set; }

        [JsonProperty("last_contacted")]
        public DateTime? LastContacted { get; set; }

        [JsonProperty("last_contacted_mode")]
        public string LastContactedMode { get; set;  }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("parent_sales_account_id")]
        public long? ParentSalesAccountID {get;set; }

        [JsonProperty("create_at")]
        public DateTime CreateAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("last_assigned_at")]
        public DateTime? LastAssignedAt { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }


        [JsonProperty("custom_field")]
        public object CustomField { get; set; }

        //public long team_user_ids { get; set; }


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
