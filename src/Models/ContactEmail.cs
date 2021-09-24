using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Models
{
    //"id": 30005404582,
    //   "value": "willem@jtg.nl",
    //   "is_primary": true,
    //   "label": "Work",
    //   "_destroy": false
    public class ContactEmail
    {
        public long id { get; set; }
        public string value { get; set; }
        public bool is_primary { get; set; }

        public string label { get; set; }

        public bool _destroy { get; set; }
          
    }
}
