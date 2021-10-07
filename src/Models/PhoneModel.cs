using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public class PhoneModel : PhoneParent
    {
        public bool call_direction { get; set; }
        public string targetable_type { get; set; }
        public Targetable targetable { get; set; }
        public Note note { get; set; }


        public int id { get; set; }
        public object call_duration { get; set; }
        public object recording_duration { get; set; }
        public string status { get; set; }
        public object recording { get; set; }
        public DateTime conversation_time { get; set; }
        public int cost { get; set; }
        public bool is_manual { get; set; }
        public object phone_number_id { get; set; }
        public object phone_caller_id { get; set; }
        public int note_id { get; set; }


        public class Targetable
        {
            public string id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string work_number { get; set; }
            public string mobile_number { get; set; }
        }

        public class Note
        {
            public string description { get; set; }
        }


    }
}
