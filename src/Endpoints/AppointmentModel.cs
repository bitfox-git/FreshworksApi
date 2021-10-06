using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class AppointmentModel : AppointmentObjects
    {




            public string title { get; set; }
            public string description { get; set; }
            public string from_date { get; set; }
            public string end_date { get; set; }
            public string time_zone { get; set; }
            public string location { get; set; }
            public string targetable_id { get; set; }
            public string targetable_type { get; set; }
            public Appointment_Attendees_Attributes[] appointment_attendees_attributes { get; set; }
        

        public class Appointment_Attendees_Attributes
        {
            public string attendee_type { get; set; }
            public string attendee_id { get; set; }
        }




    }
}
