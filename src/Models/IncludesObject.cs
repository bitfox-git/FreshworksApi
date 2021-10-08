using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class IncludesObject: ErrorObject
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
        //    "contact": {
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
        public List<User> Territories { get; set; } = null;


        [JsonProperty("sales_accounts")]
        public List<User> SalesAccounts { get; set; } = null;


        [JsonProperty("contact")]
        public IncludesModel Contact { get; set; } = null;

    }
}
