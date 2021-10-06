using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class SalesEndpoints: BasePortal<SalesObject, SalesObject, SalesModel>
    {
        public SalesEndpoints(string baseURL, string apikey) : base($"{baseURL}/api/sales_activities", apikey)
        { }
    }
}
