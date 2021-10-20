using AutoMapper;
using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Endpoints.Contact;
using Bitfox.Freshworks.Endpoints.Deals;
using Bitfox.Freshworks.Endpoints.Sales;
using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Includes
    {
        // Parents
        [JsonReturnParentProperty]
        [JsonProperty("sales_account")]
        public Account SalesAccount { get; set; } = null;

        [JsonProperty("sales_accounts")]
        public List<Account> SalesAccounts { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("contact")]
        public Contact Contact { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("contacts")]
        public List<Contact> Contacts { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("deal")]
        public Deal Deal { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("deals")]
        public List<Deal> Deals { get; set; } = null;




        [JsonReturnParentProperty]
        [JsonProperty("business_types")]
        public List<BusinessType> BusinessTypes { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("users")]
        public List<User> Users { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("industry_types")]
        public List<IndustryType> IndustryTypes { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("child_sales_accounts")]
        public List<Sale> ChildSalesAccounts { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("territories")]
        public List<User> Territories { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("tasks")]
        public List<User> Tasks { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("appointments")]
        public List<User> Appointments { get; set; } = null;

        // children
        [JsonProperty("task_ids")]
        public List<long> TaskIDs { get; set; } = null;

        [JsonProperty("contact_ids")]
        public List<long> ContactIDs { get; set; } = null;

        [JsonProperty("deal_ids")]
        public List<long> DealIDs { get; set; } = null;

        [JsonProperty("child_sales_account_ids")]
        public List<long> ChildSalesAccountIDs { get; set; } = null;

        [JsonProperty("industry_type_id")]
        public long? IndustryTypeID { get; set; } = null;

        [JsonProperty("lead_source")]
        public List<User> LeadSource { get; set; } = null;

        [JsonProperty("campaigns")]
        public List<User> Campaigns { get; set; } = null;

        [JsonProperty("notes")]
        public List<User> Notes { get; set; } = null;


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

        [JsonProperty("appointment_ids")]
        public List<long> AppointmentIDs { get; set; } = null;

        [JsonProperty("note_ids")]
        public List<long> NoteIDs { get; set; } = null;

        [JsonProperty("territory_id")]
        public long? TerritoryID { get; set; } = null;

        [JsonProperty("sales_account_id")]
        public long? SalesAccountID { get; set; } = null;

        public bool IsEmpty()
        {
            var values = GetType()
                     .GetProperties()
                     .Where(field => field.GetValue(this) != null)
                     .ToList();

            return (values.Count == 0);
        }

        public bool Update<TEntity>(string content)
        {
            Includes model;
            try
            {
                var settings = new JsonSerializerSettings
                {
                    MissingMemberHandling = MissingMemberHandling.Error
                };
                model = JsonConvert.DeserializeObject<Includes>(content, settings);
            }
            catch (JsonSerializationException ex)
            {
                throw new JsonSerializationException(
                    $"{ex.Message}\n Failed on Content:\n" + content
                );
            }

            bool hasData = false;

            // update this includes
            foreach (var property in typeof(Includes).GetProperties())
            {
                var obj = property.GetValue(model, null);
                if (obj != null)
                {
                    property.SetValue(this, obj);
                    hasData = true;
                }
            }

            return hasData;
        }

    }
}
