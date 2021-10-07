using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class SalesController: BaseController<SalesPayload, SalesModel>, ISalesController
    {
        public SalesController(string baseURL, string apikey) : base($"{baseURL}/api/sales_activities", apikey)
        { }
    }
}
