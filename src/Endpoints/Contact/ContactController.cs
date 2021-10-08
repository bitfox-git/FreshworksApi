using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Endpoints.Contact;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    class ContactController : BaseController<IContactPayload, ContactParent>, IContactController
    {
        public ContactController(string BaseURL, string apikey) : base($"{BaseURL}/api/contacts", apikey)
        { }
    }
}
