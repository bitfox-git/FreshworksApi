using Bitfox.Freshworks;
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
            //var result = await client.Selector.Deals.GetReasons();
            //var result = await client.Selector.Deals.GetTypes();
            //var result = await client.Selector.Deals.GetPaymentStatuses();
            //var result = await client.Selector.Deals.GetPipelines();
            //var result = await client.Selector.Deals.GetPipelinesOnID(17000029663);
            //var result = await client.Selector.Sales.GetActivityTypes();
            //var result = await client.Selector.Sales.GetActivityEntityTypes();
            //var result = await client.Selector.Sales.GetActivityOutcomes();
            //var result = await client.Selector.Sales.GetActivityOutcomesOnID(17000241379);
            //var result = await client.Selector.GetOwners();
            //var result = await client.Selector.GetCurrencies();
            //var result = await client.Selector.GetIndustryTypes();
            //var result = await client.Selector.GetBusinessTypes();
            //var result = await client.Selector.GetContactStatuses();
            //var result = await client.Selector.GetLifecycleStages();

            #endregion

            #region Contact

            //ContactObject contactObj = new();
            //contactObj.Contact = new()
            //{
            //    FirstName = "John",
            //    LastName = "Doe",
            //    JobTitle = "None",
            //    Email = "newContent@gmail.com",
            //    DisplayName = "okido",
            //    Avatar = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/User_icon_2.svg/2048px-User_icon_2.svg.png",
            //    WorkNumber = "6121212",
            //    MobileNumber = "+316121212",
            //    Address = "Heasdasiweg 6s",
            //    City = "Ouerd-Albasdlas",
            //    State = "South-Holland",
            //    ZipCode = "2999LC",
            //    Country = "Netherlands"
            //};

            //ContactObject updateObj = new();
            //updateObj.Contact = new()
            //{
            //    FirstName = "John",
            //    LastName = "Doe",
            //    JobTitle = "None"
            //};

            //ContactObject cloneObj = new();
            //cloneObj.Contact = new()
            //{
            //    FirstName = "John",
            //    LastName = "Doe",
            //    JobTitle = "None",
            //    Email = "newContent3@gmail.com"
            //};

            //BulkAssignObject assignObj = new()
            //{
            //    OwnerID = 17007472886,
            //    SelectedIDs = new long[] { 17001463640 }
            //};

            //BulkDeleteObject deleteObj = new()
            //{
            //    SelectedIDs = new long[] { 17001463630 }
            //};

            //var result = await client.Contact.Create(contactObj);
            //var result = await client.Contact.GetAllByID(17001463640);
            //var result = await client.Contact.GetByID(17007472886);
            //var result = await client.Contact.UpdateByID(17007472886, updateObj);
            //var result = await client.Contact.DeleteByID(17007472886);
            //var result = await client.Contact.CloneByID(17007472886, cloneObj);
            //var result = await client.Contact.ForgetByID(17007476714);
            //var result = await client.Contact.CreateBulk(assignObj);
            //var result = await client.Contact.DeleteBulk(deleteObj);
            //var result = await client.Contact.GetAllFields();
            //var result = await client.Contact.GetAllActivitiesByID(17007472886);

            #endregion

            #region Account

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


            #endregion


            Console.WriteLine(result);


















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
