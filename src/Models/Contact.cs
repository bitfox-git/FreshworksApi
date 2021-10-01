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
        public long id { get; set; }

        public string first_name { get; set; }
        public string last_name { get; set; }
        public string display_name { get; set; }
        
        public string avatar { get; set; }
        public string job_title { get; set; }
        public string city  { get; set; }
        public string state { get; set; }


        public string ZipCode { get; set; }

        public string Country { get; set; }

       

        [Obsolete("Use the emails property instead.")]
        public string email { get; set; }

        public List<ContactEmail> emails { get; set; }
        
        public string time_zone { get; set; }
        
        public string work_number { get; set; }
        public string mobile_number { get; set; }
        public string address  { get; set; }
        
        public DateTime? last_seen { get; set; }
        
        public int lead_score { get; set; }
        
        public DateTime? last_contacted { get; set; }
        public double? open_deals_amount { get; set; }
        public double? won_deals_amount { get; set; }
        
        public string last_contacted_sales_activity_mode { get; set; }
        
        public object custom_field { get; set; }
        
        public DateTime created_at { get; set; }


        [JsonIgnore()]
        public DateTime updated_at { get; private set; }
        
        //keyword": null??

        public string medium { get; set; }
        public string last_contacted_mode { get; set; }
        
        [JsonProperty("recent_note")]
        public string RecentNote{ get; }
        
        public int? won_deals_count { get; set; }

        //"last_contacted_via_sales_activity": null,
        public int? completed_sales_sequences { get; set; }
        
        //"active_sales_sequences": null,
        
        //"web_form_ids": null,
        public int open_deals_count { get; set; }

        public DateTime? last_assigned_at { get; set; }
          
        public List<string> tags { get; set; }
        
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string linkedin { get; set; }
        public bool is_deleted { get; set; }

        //"team_user_ids": null,
        public string external_id { get; set; }
        
        public string work_email { get; set; }

        //TODO : make enum?
        public int subscription_status { get; set; }

        /// <summary>
        /// list of integers, seperated by semicolon
        /// for example: 3;4;1
        /// </summary>
        public string subscription_types { get; set; }


        /// TODO : should be private field + detect deserialization state? (null vs empty)?
       
       
        /// <summary>
        /// list of listids, but only filled when ?include=list?
        /// </summary>
        public long[] list_ids { get; set; }

        public int customer_fit { get; set; }
        
        public bool has_duplicates { get; set; }

        public bool duplicates_searched_today { get; set; }
        public bool has_connections { get; set; }
        
        public bool connections_searched_today { get; set; }

        //public "phone_numbers": [],

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<ContactSalesAccountPartial> sales_accounts { get; set; }

        public long lifecycle_stage_id { get; set; }

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
