using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class ContactPortal: BasePortal<ContactModel>
    {
        public ContactPortal(string baseURL, string apikey): base($"{baseURL}/api/contacts", apikey)
        { }

        // 





    }
}
