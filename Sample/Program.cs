﻿using Bitfox.Freshworks;
using Bitfox.Freshworks.Models;
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

            // Selection
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

            // Contact
            ContactModel contactModel = new();
            contactModel.Contact = new()
            {
                FirstName = "John",
                LastName = "Doe",
                JobTitle = "None",
                Email = "test12@gmail.com",
                DisplayName = "okido",
                Avatar = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/User_icon_2.svg/2048px-User_icon_2.svg.png",
                WorkNumber = "6121212",
                MobileNumber = "+316121212",
                Address = "Heiweg 6",
                City = "Oud-Alblas",
                State = "South-Holland",
                ZipCode = "2969LC",
                Country =  "Netherlands"
            };



            // var result = await client.Contact.Create(contactModel);
            // var result = await client.Contact.GetAll(17001463637);
            // var result = await client.Contact.GetOnID(17007304795);
            // var result = await client.Contact.UpdateOnID(17007304795, contactModel);
            // var result = await client.Contact.DeleteOnID(17007333582);

            //Create
            //GetOnID
            //GetAll
            //UpdateOnID
            //DeleteOnID
            //Create
            //GetOnID
            //GetAll
            //UpdateOnID
            //CloneOnID
            //DeleteOnID
            //ForgetOnID
            //DeleteOnBulk
            //GetAllFields

            // notes, search, phone, files


            //var result = await client.Query<>();
            //var result = await client.Query<Contact>().GetAll();
            //var result = await client.Query<Contact>().GetByID(17000207787);

            Console.WriteLine(result);


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
