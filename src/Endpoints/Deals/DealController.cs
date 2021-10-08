using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    public class DealController : BaseController<IDealPayload, DealParent>, IDealController
    {
        public DealController(string BaseURL, string apikey) : base($"{BaseURL}/api/deals", apikey)
        { }

    }
}
