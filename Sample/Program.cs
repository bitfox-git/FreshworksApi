using Freshworks.CRM.Client;
using Freshworks.CRM.Client.Selectors;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Sample
{

    class CustomSalesAccountFields
    {
        public string cf_external_id { get; set; }
    }

    class Program
    {
        static async Task Main(string[] args)
        {

            //
            var conn = new FWConnection("lucrasoft-team", "2FN2cs0zL7r1ctI71YXSAA");

            //get the sales account filters

            var account = await conn.GetSalesAccountByID(30002095168);

            var cf = account.GetCustomFields<CustomSalesAccountFields>();


            Console.WriteLine(cf);


            cf.cf_external_id = "13";
            account.city = "Zwijndrecht";
            account.SetCustomFields(cf);
            var account2 = await conn.Update(account);


            var a2test = (JObject)(account2.custom_field);
            var a2test2 = a2test.ToObject<CustomSalesAccountFields>();
            Console.WriteLine(a2test2.cf_external_id);
            

            //var accounts = await conn.GetSalesAccountsAll();
            //foreach (var acc in accounts)
            //{
            //    //
            //}



            //var b = 12;
            //var lookups = await conn.GetSelectorsAsync<IndustryTypes>();

            //foreach (var u in lookups.industry_types)
            //{
            //    Console.WriteLine($"{u.id} - {u.name}");
            //}

        }
    }
}
