using Bitfox.Freshworks;
using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using Bitfox.Freshworks.NetworkObjects;
using Bitfox.Freshworks.Selectors;
using Newtonsoft.Json.Linq;
using System;
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

            #region Selection

            //var result = await client.Selection<Campaigns>();   // TODO: create sample data that we know, how
            //var result = await client.Selection<DealProducts>();// TODO: create sample data that we know, how
            //var result = await client.Selection<Territories>(); // TODO: create sample data that we know, how
            // var result = await client.Selector.Deals.GetReasons();
            // var result = await client.Selector.Deals.GetTypes();
            // var result = await client.Selector.Deals.GetPaymentStatuses();
            // var result = await client.Selector.Deals.GetPipelines();
            // var result = await client.Selector.Deals.GetPipelinesOnID(17000029663);
            // var result = await client.Selector.Sales.GetActivityTypes();
            // var result = await client.Selector.Sales.GetActivityEntityTypes();
            var result = await client.Selector.Sales.GetActivityOutcomes();
            //var result = await client.Selector.Sales.GetActivityOutcomesOnID(17000241379);
            //var result = await client.Selector.GetOwners();
            //var result = await client.Selector.GetCurrencies();
            //var result = await client.Selector.GetIndustryTypes();
            //var result = await client.Selector.GetBusinessTypes();
            //var result = await client.Selector.GetContactStatuses();
            //var result = await client.Selector.GetLifecycleStages();

            Console.WriteLine(result);

            #endregion

            #region Contact
            //ContactPayload payload = new();

            //payload.Contact = new()
            //{
            //    FirstName = "James",
            //    LastName = "Sampleton (test)",
            //    Email = "test1@email.com",
            //    MobileNumber = "1-926-555-9503"
            //};

            //var contact = await client.Contact.Create(payload);
            //var contact = await client.Contact.GetByID(17007697582);
            //var contact = await client.Contact.GetAllByID(17001463640);
            //var contact = await client.Contact.UpdateByID(17007697582, payload);
            //var contact = await client.Contact.DeleteByID(17007697582);

            //var contact = await client.Contact.CloneByID(17007697582, payload);
            //var contact = await client.Contact.ForgetByID(17007697582);
            //var contact = await client.Contact.CreateBulk(payload);
            //var contact = await client.Contact.DeleteBulk(payload);
            //var contact = await client.Contact.GetAllFields();
            //var contact = await client.Contact.GetAllActivitiesByID(17007472886);

            /*Console.WriteLine(contact);*/

            #endregion

            #region Account
            AccountPayload payload = new();


            //AccountObject accountObj = new();
            //accountObj.Account = new()
            //{
            //    Name = "John",
            //    Address = "Doe",
            //    City = "None",
            //    State = "newContent@gmail.com",
            //    ZipCode = "okido",
            //    Avatar = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/User_icon_2.svg/2048px-User_icon_2.svg.png",
            //    Country = "Netherlands"
            //};

            //AccountObject accountUpdateObj = new();
            //accountUpdateObj.Account = new()
            //{
            //    Name = "niek 2"
            //};

            //AccountObject accountCloneObj = new();
            //accountCloneObj.Account = new()
            //{
            //    Name = "John"
            //};

            //AccountBulkDeleteObject deleteObj = new()
            //{
            //    SelectedIDs = new long[] { 17001220091 },
            //    DeleteAssociatedContactsDeals = false
            //};

            //var result = await client.Account.Create(accountObj);
            //var result = await client.Account.GetAllByID(17001463655);
            //var result = await client.Account.GetByID(17001220076);
            //var result = await client.Account.UpdateByID(17001219885, accountUpdateObj);
            //var result = await client.Account.DeleteByID(17001219885);
            //var result = await client.Account.CloneByID(17001220091, accountCloneObj);
            //var result = await client.Account.ForgetByID(17001220091);
            //var result = await client.Account.DeleteBulk(deleteObj);
            //var result = await client.Account.GetAllFields();

            #endregion

            #region Deals

            //DealObject createObj = new();
            //createObj.Deal = new()
            //{
            //    Name = "Okido",
            //    Amount = "12",
            //    CurrencyID = 17000029017,
            //    SalesAccountID = 17001067154,
            //    OwnerID = 17000033771
            //};

            //DealObject updateObj = new();
            //updateObj.Deal = new()
            //{
            //    Name = "niek 2"
            //};


            //BulkDeleteObject deleteObj = new()
            //{
            //    SelectedIDs = new long[] { 17000498540 }
            //};

            //var result = await client.Deal.Create(createObj);
            //var result = await client.Deal.GetAllByID(17001463650);
            //var result = await client.Deal.GetByID(17000498540);
            //var result = await client.Deal.UpdateByID(17000498540, updateObj);
            //var result = await client.Deal.DeleteByID(17000498540);
            //var result = await client.Deal.CloneByID(17000498540, updateObj);
            //var result = await client.Deal.ForgetByID(17001220091);
            //var result = await client.Deal.DeleteBulk(deleteObj);
            //var result = await client.Deal.GetAllFields();

            #endregion

            #region Notes
            //var result = client.Note.Create();
            //var result = client.Note.UpdateByID();
            //var result = client.Note.DeleteByID();
            #endregion

            #region Tasks

            //TaskObject createObj = new();
            //createObj.Task = new()
            //{
            //    Title = "Okido",
            //    Description = "12",
            //    TargetableID = "17001067154",
            //    OwnerID = 17000033771
            //};

            //TaskObject updateObj = new();
            //updateObj.Task = new()
            //{
            //    Status = 2
            //};

            //var result = await client.Task.Create(createObj);
            //var result = await client.Task.GetAllByID(17001463650);
            //var result = await client.Task.GetByID(17000498540);
            //var result = await client.Task.UpdateByID(17000498540, updateObj);
            //var result = await client.Task.DeleteByID(17000498540);
            //var result = await client.Task.UpdateMarkByID(17000498540, updateObj);
            //var result = await client.Task.DeleteMarkByID(17000498540);
            //var result = await client.Task.CloneByID(17000498540, updateObj);
            //var result = await client.Task.ForgetByID(17001220091);
            //var result = await client.Task.DeleteBulk(deleteObj);
            //var result = await client.Task.GetAllFields();

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

            //var result = await client.Appointment.Create(createObj);
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

            //var result = await client.Sales.Create(createObj);
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
