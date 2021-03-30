using System;
using System.Collections.Generic;
using System.Text;

namespace Freshworks.CRM.Client.Models
{

//    "errors": {
//        "code": 403,
//        "message": [
//            "U bent niet bevoegd om deze bewerking uit te voeren."
//        ]
//}

public class Error
    {
        public int code { get; set; }
        public string[] message { get; set; }
    }
}
