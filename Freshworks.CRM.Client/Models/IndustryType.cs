using System;
using System.Collections.Generic;
using System.Text;

namespace Freshworks.CRM.Client.Models
{
              //"id": 30000676973,
            //"name": "Accounting",
            //"position": 1,
            //"partial": true
    public class IndustryType
    {
        public long id { get; set; }
        public string name { get; set; }
        public int position { get; set; }
        public bool partial { get; set; }
    }
}
