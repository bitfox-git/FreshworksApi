using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public class PhoneParent : ErrorObject
    {
        [JsonProperty("phone_call")]
        public PhoneModel Call { get; set; } = null;

        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }

        [JsonProperty("phone_numbers")]
        public object[] PhoneNumbers { get; set; }

        [JsonProperty("phone_callers")]
        public object[] PhoneCallers { get; set; }

        [JsonProperty("notes")]
        public Note[] Notes { get; set; }

        [JsonProperty("user")]
        public User[] Users { get; set; }

        [JsonProperty("targetables")]
        public Targetable1[] Targetables { get; set; }

        [JsonProperty("phone_calls")]
        public PhoneModel PhoneCalls { get; set; }
        

        public class Targetable
        {
            public string type { get; set; }
            public int id { get; set; }
        }

        public class Contact
        {
            public bool partial { get; set; }
            public int id { get; set; }
        }

        public class Note
        {
            public int id { get; set; }
            public string description { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public int creater_id { get; set; }
            public int targetable_id { get; set; }
        }

        public class User
        {
            public int id { get; set; }
            public string display_name { get; set; }
            public string email { get; set; }
            public bool is_active { get; set; }
        }

        public class Targetable1
        {
            public int id { get; set; }
            public string display_name { get; set; }
            public string email { get; set; }
        }



    }
}
