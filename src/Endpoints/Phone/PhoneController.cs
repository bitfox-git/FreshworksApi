using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public class PhoneController : BaseController<IPhonePayload, PhoneParent>, IPhoneController
    {
        public PhoneController(string baseURL, string apikey) : base($"{baseURL}/api/phone_calls", apikey)
        { }

        // Manual call log
        public async Task<PhoneParent> GetCallLogs(IPhonePayload body, string include = null, int? page = null)
        {
            var path = SetParams($"/document_links", include, page);
            return await PostApiRequest<IPhonePayload, PhoneParent>(path, body);
        }
    }
}
