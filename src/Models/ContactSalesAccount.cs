using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Models
{

     //           "partial": true,
     //           "id": 30002095168,
     //           "name": "JTG Trading BV",
     //           "avatar": null,
     //           "website": "www.jtg.nl",
     //           "open_deals_amount": "1200.0",
     //           "open_deals_count": 1,
     //           "won_deals_amount": "0.0",
     //           "won_deals_count": 0,
     //           "last_contacted": null,
     //           "is_primary": true
    
    public class ContactSalesAccountPartial
    {

        public long id { get; set; }
        public bool is_primary { get; set; }
    }
}
