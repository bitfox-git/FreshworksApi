using Bitfox.Freshworks;
using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Endpoints.Contact;
using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using Bitfox.Freshworks.NetworkObjects;
using Bitfox.Freshworks.Selectors;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample
{

    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new CRMClientBuilder()
                                .SetSubdomain("notdetected-team")
                                .SetApiKey("OOuMhjaasZwwkfzO__tZFQ")
                                .Build();

            //        "users",
            //        "targetable",
            //        "owner",
            //        "creater",
            //        "updater",
            //        "source",
            //        "campaign",
            //        "tasks",
            //        "appointments",
            //        "notes",
            //        "deals",
            //        "sales_accounts",
            //        "territory",
            //        "sales_account",
            //        "territory",
            //        "business_type",
            //        "tasks",
            //        "contacts",
            //        "industry_type",
            //        "child_sales_accounts",
            //        "deal_stage",
            //        "deal_type",
            //        "deal_reason",
            //        "deal_payment_status",
            //        "deal_product",
            //        "currency",
            //        "probability",
            //        "created_at",
            //        "updated_at",
            //        "field_group",
            //        "user",
            //        "users",
            //        "targetable",
            //        "appointment_attendees",
            //        "owner",
            //        "creater"
            Params _params = new Params()
            {
                Includes = new List<string>()
                {
                    "creater", "owner"
                }
            };



            #region Selection

            //var result = await client.Selector.GetTerritories();
            //var result = await client.Selector.GetCampaigns();
            //var result = await client.Selector.GetOwners();
            //var result = await client.Selector.GetCurrencies();
            //var result = await client.Selector.GetContactStatuses();
            //var result = await client.Selector.GetBusinessTypes();
            //var result = await client.Selector.GetLifecycleStages();
            //var result = await client.Selector.GetIndustryTypes();
            //var result = await client.Selector.Sales.GetActivityTypes();
            //var result = await client.Selector.Sales.GetActivityEntityTypes();
            //var result = await client.Selector.Sales.GetActivityOutcomes();
            //var result = await client.Selector.Sales.GetActivityOutcomesOnID(17000241379);
            //var result = await client.Selector.Deals.GetReasons();
            //var result = await client.Selector.Deals.GetTypes();
            //var result = await client.Selector.Deals.GetPaymentStatuses();
            //var result = await client.Selector.Deals.GetPipelines();
            //var result = await client.Selector.Deals.GetPipelinesOnID(17000029663);
            //var result = await client.Selector.Deals.GetProducts();// TODO (can't get response)

            //Console.WriteLine(result);

            #endregion

            #region Contact

            //IContactPayload payload = new ContactParent
            //{
            //    Contact = new ContactModel
            //    {
            //        FirstName = "James",
            //        LastName = "Sampleton (test)",
            //        Email = "test321@email.com",
            //        MobileNumber = "1-926-555-9503"
            //    }
            //};

            //var result = await client.Contact.Insert(payload);
            //var result = await client.Contact.GetByID(17007795289, _params);
            //var result = await client.Contact.GetAllByID(17001463640);
            //var result = await client.Contact.UpdateByID(17007795289, payload);
            //var result = await client.Contact.DeleteByID(17007795289);
            //var result = await client.Contact.CloneByID(17007771004, payload);
            //var result = await client.Contact.ForgetByID(17007795289);
            //var result = await client.Contact.CreateBulk(payload);
            //var result = await client.Contact.DeleteBulk(payload);
            //var result = await client.Contact.GetAllFields(); 
            //var result = await client.Contact.GetAllActivitiesByID(17007771004);

            //Console.WriteLine(contact);

            #endregion

            #region Account

            //AccountParent parent = new()
            //{
            //    Account = new()
            //    {
            //        Name = "John qwerty",
            //        Address = "Doe",
            //        City = "None",
            //        State = "newContent1@gmail.com",
            //        ZipCode = "okido",
            //        Avatar = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/User_icon_2.svg/2048px-User_icon_2.svg.png",
            //        Country = "Netherlands"
            //    }
            //};

            //AccountParent update = new()
            //{
            //    Account = new()
            //    {
            //        Name = "niek 2"
            //    }
            //};

            //BulkDelete delete = new()
            //{
            //    SelectedIDs = new long[] { 17001140566 },
            //    DeleteAssociatedContactDeals = false
            //};
            //ID = 17001067154,


            //ContactModel contact = new()
            //{
            //    FirstName = "niek"
            //};

            Account account = new()
            {
                ID = 17001334058
            };

            //var result = await client.Insert(account);
            //var result = await client.Account.Insert(account);
            //var result = await client.Account.Insert<AccountModel>(account);

            //var result = await client.Update(account);
            //var result = await client.Account.Update(account);
            //var result = await client.Account.Update<AccountModel>(account);

            //var result = await client.Clone(account);
            //var result = await client.Account.Clone(account);
            //var result = await client.Account.Clone<AccountModel>(account);

            //var result = await client.Query()
            //                        .Include("owner")
            //                        .Include("tasks")
            //                        .GetByID<AccountModel>(17001294725);
            //var result = await client.Account.Query<AccountModel>()
            //                        .Include("owner")
            //                        .Include("tasks")
            //                        .GetByID(17001294725);
            //var result = await client.Query<AccountModel>()
            //                        .Include("page")
            //                        .GetAllByID(17001463655);
            //var result = await client.Account.Query<AccountModel>()
            //                        .Include("page")
            //                        .GetAllByID(17001463655);
            //var result = await client.Query().GetAllFields<AccountModel>();
            //var result = await client.Account.Query().GetAllFields<AccountModel>();

            //var result = await client.Delete(account);
            //var result = await client.Account.Delete(account);
            //var result = await client.Account.Delete<AccountModel>(account);
            //var result = await client.Account.Delete<AccountModel>(17001140566);

            //var result = await client.DeleteBulk(account);
            //var result = await client.Account.DeleteBulk(account);
            //var result = await client.Account.DeleteBulk<AccountModel>(account);

            //var result = await client.Forget(account);
            //var result = await client.Account.Forget(account);
            //var result = await client.Account.Forget<AccountModel>(account);
            //var result = await client.Account.Forget<AccountModel>(17001140566);







            //var result = await client.Update(17001463655, account);

            //var result = await  client.Update(account);
            //client.Account.Update(account);

            //var result = await client.GetByID(account);
            //var result = await client.GetByID<AccountModel>(17001294725);
            //var result = await client.Account.GetByID(17001294725);

            //var result = await client.GetAllByID(account);
            //var result = await client.GetAllByID<AccountModel>(17001463655);
            //result = await client.Account.GetAllByID(17001463655);






            //var result = await client.Account.UpdateView(17001067154, account);




            //var result = await client.Clone(long id, account);
            //client.Account.Clone




            //var result = await client.Update(long id, account);

            //client.Account.
            //var result = await client.Query<AccountModel>(17001140566).;// _params



            //Console.WriteLine(result);


            //await client.Account.CloneByID(17001140566);

            //client.

            //var result = await client.Account.Insert(parent);
            //var result = await client.Account.GetByID(17001140566);// _params
            //var result = await client.Account.GetAllByID(17001463655);
            //var result = await client.Account.UpdateByID(17001140566, update);
            //var result = await client.Account.DeleteByID(17001463655);
            //var result = await client.Account.CloneByID(17001140566, update);
            //var result = await client.Account.ForgetByID(17001220091);
            //var result = await client.Account.DeleteBulk(delete);
            //var result = await client.Account.GetAllFields();

            #endregion

            #region Deals

            //DealParent parent = new()
            //{
            //    Deal = new()
            //    {
            //        Name = "Okido 222",
            //        Amount = "12",
            //        CurrencyID = 17000029017,
            //        SalesAccountID = 17001067154,
            //        OwnerID = 17000033771
            //    }
            //};

            //DealParent update = new()
            //{
            //    Deal = new()
            //    {
            //        Name = "niek 2"
            //    }
            //};

            //BulkDelete delete = new()
            //{
            //    SelectedIDs = new long[] { 17000506403 }
            //};

            //var result = await client.Deal.Insert(parent);
            //var result = await client.Deal.GetByID(17000506403);// _params
            //var result = await client.Deal.GetAllByID(17001463652);
            //var result = await client.Deal.UpdateByID(17000506403, update);
            //var result = await client.Deal.DeleteByID(17001463652);
            //var result = await client.Deal.CloneByID(17000506403, update);
            //var result = await client.Deal.ForgetByID(17000506403);
            //var result = await client.Deal.DeleteBulk(delete);
            //var result = await client.Deal.GetAllFields();

            #endregion

            #region Notes

            //NoteParent parent = new()
            //{
            //    Note = new()
            //    {
            //        Description = "Test from code",
            //        TargetableType = "SalesAccount",
            //        TargetableID = 17001160974
            //    }
            //};

            //NoteParent update = new()
            //{
            //    Note = new()
            //    {
            //        Description = "niek 2",
            //        TargetableID = 17001160974
            //    }
            //};

            //var result = await client.Note.Insert(parent);
            //var result = await client.Note.UpdateByID(17001572816, update);
            //var result = await client.Note.DeleteNoteByID(17001572826);

            #endregion

            #region Tasks
            //TaskParent parent = new()
            //{
            //    Task = new()
            //    {
            //        Title = "(Sample) okido",
            //        Description = "Send the proposal document and follow up with this contact after it.",
            //        OwnerID = 17000033771,
            //        CreaterID = 17000033771,
            //        UpdaterID = 17000033771
            //    }
            //};

            //TaskParent update = new()
            //{
            //    Task = new()
            //    {
            //        Title = "(Sample) Send the proposal document"
            //    }
            //};

            //var result = await client.Task.Insert(parent);
            //var result = await client.Task.GetByID(17000369384); // _params
            //var result = await client.Task.GetAllByFilter("open");
            //var result = await client.Task.UpdateByID(17000369384, update);
            //var result = await client.Task.DeleteByID(17000369384);

            #endregion

            #region Appointments

            //AppointmentObject createObj = new();
            //createObj.Appointment = new()
            //{
            //    Title = "Okido",
            //    Description = "12",
            //    TargetableID = "17001067154",
            //    OwnerID = 17000033771
            //};

            //AppointmentObject updateObj = new();
            //updateObj.Appointment = new()
            //{
            //    Status = 2
            //};

            //var result = await client.Appointment.Insert(createObj);
            //var result = await client.Appointment.GetAllByID(17001463650);
            //var result = await client.Appointment.GetByID(17000498540);
            //var result = await client.Appointment.UpdateByID(17000498540, updateObj);
            //var result = await client.Appointment.DeleteByID(17000498540);
            //var result = await client.Appointment.UpdateMarkByID(17000498540, updateObj);
            //var result = await client.Appointment.DeleteMarkByID(17000498540);
            //var result = await client.Appointment.CloneByID(17000498540, updateObj);
            //var result = await client.Appointment.ForgetByID(17001220091);
            //var result = await client.Appointment.DeleteBulk(deleteObj);
            //var result = await client.Appointment.GetAllFields();

            #endregion

            #region Sales

            //SalesObject createObj = new();
            //createObj.Activity = new()
            //{
            //    Title = "Okido",
            //    Description = "12",
            //    TargetableID = "17001067154",
            //    OwnerID = 17000033771
            //};

            //SalesObject updateObj = new();
            //updateObj.Activity = new()
            //{
            //    Status = 2
            //};

            //var result = await client.Sales.Insert(createObj);
            //var result = await client.Sales.GetAllByID(17001463650);
            //var result = await client.Sales.GetByID(17000498540);
            //var result = await client.Sales.UpdateByID(17000498540, updateObj);
            //var result = await client.Sales.DeleteByID(17000498540);
            //var result = await client.Sales.UpdateMarkByID(17000498540, updateObj);
            //var result = await client.Sales.DeleteMarkByID(17000498540);
            //var result = await client.Sales.CloneByID(17000498540, updateObj);
            //var result = await client.Sales.ForgetByID(17001220091);
            //var result = await client.Sales.DeleteBulk(deleteObj);
            //var result = await client.Sales.GetAllFields();

            #endregion

            #region Search

            #endregion

            #region Phone
            //client.Phone.GetCallLogs(id);
            #endregion

            #region Files
            //client.File.CreateFile();// TODO
            //client.File.CreateLink();
            //client.File.GetAllFilesAndLinksByID();
            #endregion



            //Console.WriteLine(result);


















            // notes, search, phone, files


            //var result = await client.Query<>();
            //var result = await client.Query<Contact>().GetAllByID();
            //var result = await client.Query<Contact>().GetByID(17000207787);


            //var y= myContact.updated_at;


            //myContact.Country = "The Netherlands";

            //var result = await client.Update(myContact);




            ////get an account
            //var account = await conn.GetByID<SalesAccount>(30002095168);

            //var cf = account.GetCustomFields<CustomSalesAccountFields>();

            //Console.WriteLine(cf);
            //cf.cf_external_id = "13";
            //account.city = "Zwijndrecht";
            //account.SetCustomFields(cf);
            //var account2 = await conn.Update(account);


            //var a2test = (JObject)(account2.custom_field);
            //var a2test2 = a2test.ToObject<CustomSalesAccountFields>();
            //Console.WriteLine(a2test2.cf_external_id);
        }
    }
}
