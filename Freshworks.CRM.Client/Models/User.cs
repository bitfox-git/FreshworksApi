using System;
using System.Collections.Generic;
using System.Text;

namespace Freshworks.CRM.Client.Models
{

        //"id": 30000015422,
        //    "display_name": "Lucas Vos",
        //    "email": "lucas@lucrasoft.nl",
        //    "is_active": true,
        //    "work_number": "+31646297351",
        //    "mobile_number": "+31646297351"
    public class User
    {

        public long id { get; set; }
        public string display_name { get; set; }
        public string email { get; set; }
        public bool is_active { get; set; }
        public string work_number { get; set; }
        public string mobile_number { get; set; }
    }
}
