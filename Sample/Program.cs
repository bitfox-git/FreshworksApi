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
            Console.WriteLine("called with new content");

            ////create an instance
            //var conn = new CRMClient("<your prefix>", "<yourkey>");

            var client = new CRMClientBuilder()
                                .SetApiKey("esrg")
                                .SetSubdomain("seg")
                                .Build();


            var myContact = await client.Query<Contact>().GetByID(1);


            var y= myContact.updated_at;


            myContact.Country = "The Netherlands";

            var result = await client.Update(myContact);


          

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
