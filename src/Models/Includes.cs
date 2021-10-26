﻿using Bitfox.Freshworks.Attributes;
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
        
        [JsonProperty("sales_account")]
        public Account Account { get; set; } = null;

        [JsonProperty("sales_accounts")]
        public List<Account> Accounts { get; set; } = null;

        
        [JsonProperty("contact")]
        public Contact Contact { get; set; } = null;

        
        [JsonProperty("contacts")]
        public List<Contact> Contacts { get; set; } = null;

        
        [JsonProperty("deal")]
        public Deal Deal { get; set; } = null;

        
        [JsonProperty("deals")]
        public List<Deal> Deals { get; set; } = null;

        
        [JsonProperty("task")]
        public TaskModel Task { get; set; } = null;

        
        [JsonProperty("tasks")]
        public List<TaskModel> Tasks { get; set; } = null;

        [JsonProperty("appointment")]
        public List<Appointment> Appointment { get; set; } = null;

        [JsonProperty("appointments")]
        public List<Appointment> Appointments { get; set; } = null;

        [JsonProperty("business_types")]
        public List<BusinessType> BusinessTypes { get; set; } = null;

        [JsonProperty("users")]
        public List<User> Users { get; set; } = null;

        [JsonProperty("industry_types")]
        public List<IndustryType> IndustryTypes { get; set; } = null;

        [JsonProperty("child_sales_accounts")]
        public List<Sale> ChildSalesAccounts { get; set; } = null;

        [JsonProperty("territories")]
        public List<User> Territories { get; set; } = null;

        [JsonProperty("lists")]
        public List<IndustryType> Lists { get; set; } = null;





        // Child
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
                    $"{ex.Message}\n Failed on Value:\n" + content
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
