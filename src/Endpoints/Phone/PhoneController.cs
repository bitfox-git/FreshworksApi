using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public class PhoneController : BaseController<PhonePayload, PhoneModel>, IPhoneController
    {
        public PhoneController(string baseURL, string apikey) : base($"{baseURL}/api/phone_calls", apikey)
        { }

        // Manual call log
        public async Task<PhoneModel> GetCallLogs(PhonePayload body)
        {
            var path = $"/document_links";
            return await PostApiRequest<PhonePayload, PhoneModel>(path, body);
        }
    }
}
