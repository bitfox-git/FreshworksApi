using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class IncludesModel
    {
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

        [JsonProperty("sales_accounts")]
        public List<SalesAccount> SalesAccounts { get; set; } = null;


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

    }
}
