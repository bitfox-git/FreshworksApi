using System;
using System.Collections.Generic;
using System.Text;

namespace Freshworks.CRM.Client.Models
{


            //"id": 30000496436,
            //"name": "My Accounts",
            //"model_class_name": "SalesAccount",
            //"user_id": 0,
            //"is_default": true,
            //"updated_at": "2021-02-17T17:20:52+01:00",
            //"user_name": null,
            //"current_user_permissions": []


    public class Filter
    {

        public long id { get; set; }
        public string name { get; set; }
        public string model_class_name { get; set; }

        public long user_id { get; set; }

        public bool is_default { get; set; }

        public DateTime updated_at { get; set; }

        public string user_name { get; set; }

           
    }
}
