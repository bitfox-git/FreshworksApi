using Freshworks.CRM.Client;
using Freshworks.CRM.Client.Selectors;
using System;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //
            var conn = new FWConnection("lucrasoft-team", "2FN2cs0zL7r1ctI71YXSAA");

            //get the 

            var lookups = await conn.GetSelectorsAsync<IndustryTypes>();

            foreach (var u in lookups.industry_types)
            {
                Console.WriteLine($"{u.id} - {u.display_name}");
            }

        }
    }
}
