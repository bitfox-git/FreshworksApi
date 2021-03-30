using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Freshworks.CRM.Client.Models
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
    public class SalesAccount : IUniqueID
    {

        public long id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string country { get; set; }
        public int? number_of_employees { get; set; }
        public double? annual_revenue { get; set; }
        public string website { get; set; }
        public long? owner_id { get; set; }

        public string phone { get; set; }

        public double? open_deals_amount { get; set; }
        public int? open_deals_count { get; set; }
        public double? won_deals_amount { get; set; }
        public int? won_deals_count { get; set; }

        public DateTime? last_contacted { get; set; } 
        public string last_contacted_mode { get; set;  }

        public string facebook { get; set; }
        public string twitter { get; set; }
        public string linkedin { get; set; }

        public long? parent_sales_account_id {get;set;}
        public DateTime create_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime? last_assigned_at { get; set; }
        public string[]? tags { get; set; }
        public bool is_deleted { get; set; }

        public object custom_field { get; set; }
        
        //public long team_user_ids { get; set; }

        public T GetCustomFields<T>()
        {

            if (custom_field == null) return default(T);
            var job = (JObject)custom_field;
            return job.ToObject<T>();
        }

        public void SetCustomFields<T>(T value)
        {
            custom_field = JObject.FromObject(value);
        }

    }
}
