using AutoMapper;
using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Includes
    {
        //{
        //    "users": [],
        //    "lead_source": [],
        //    "campaigns": [],
        //    "tasks": [],
        //    "appointments": [],
        //    "notes": [],
        //    "deals": [],
        //    "territories": [],
        //    "sales_accounts": [],
        //    "dynamic name": {
        //        "sales_accounts": [],
        //        "owner_id": null,
        //        "creater_id": 17000033771,
        //        "updater_id": 17000033771,
        //        "lead_source_id": null,
        //        "campaign_id": null,
        //        "task_ids": [],
        //        "appointment_ids": [],
        //        "note_ids": [],
        //        "deal_ids": [],
        //        "territory_id": null,
        //        "sales_account_id": null
        //    }
        //}
        [JsonProperty("users")]
        public List<User> Users { get; set; } = null;

        [JsonProperty("lead_source")]
        public List<User> LeadSource { get; set; } = null;

        [JsonProperty("campaigns")]
        public List<User> Campaigns { get; set; } = null;

        [JsonProperty("tasks")]
        public List<User> Tasks { get; set; } = null;

        [JsonProperty("appointments")]
        public List<User> Appointments { get; set; } = null;

        [JsonProperty("notes")]
        public List<User> Notes { get; set; } = null;

        [JsonProperty("deals")]
        public List<User> Deals { get; set; } = null;

        [JsonProperty("territories")]
        public List<Territory> Territories { get; set; } = null;

        [JsonProperty("sales_accounts")]
        public List<User> SalesAccounts { get; set; } = null;

        [JsonProperty("owner_id")]
        public long? OwnerID { get; set; } = null;

        [JsonProperty("creater_id")]
        public long? CreaterID { get; set; } = null;

        [JsonProperty("updater_id")]
        public long? UpdaterID { get; set; } = null;

        [JsonProperty("lead_source_id")]
        public long? LeadSourceID { get; set; } = null;

        [JsonProperty("campaign_id")]
        public long? CampaignID { get; set; } = null;

        [JsonProperty("task_ids")]
        public List<long> TaskIDs { get; set; } = null;

        [JsonProperty("appointment_ids")]
        public List<long> AppointmentIDs { get; set; } = null;

        [JsonProperty("note_ids")]
        public List<long> NoteIDs { get; set; } = null;

        [JsonProperty("deal_ids")]
        public List<long> DealIDs { get; set; } = null;

        [JsonProperty("territory_id")]
        public long? TerritoryID { get; set; } = null;

        [JsonProperty("sales_account_id")]
        public long? SalesAccountID { get; set; } = null;

        public void Update(Includes model)
        {
            foreach (var propertyInfo in typeof(Includes).GetProperties())
            {
                var obj = propertyInfo.GetValue(model);
                if (obj != null)
                {
                    propertyInfo.SetValue(this, obj);
                }
            }
        }

        public bool HasNull()
        {
            var values = GetType()
                     .GetProperties()
                     .Where(field => field.GetValue(this) != null)
                     .ToList();

            return (values.Count == 0);
        }
    }
}
