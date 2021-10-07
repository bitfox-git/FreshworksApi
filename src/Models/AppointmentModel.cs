using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class AppointmentModel : AppointmentParent
    {
        [JsonProperty("title")]
        public string Title { get; set; } = null;

        [JsonProperty("description")]
        public string Description { get; set; } = null;

        [JsonProperty("from_date")]
        public string FromDate { get; set; } = null;

        [JsonProperty("end_date")]
        public string EndDate { get; set; } = null;

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; } = null;

        [JsonProperty("location")]
        public string Location { get; set; } = null;

        [JsonProperty("targetable_id")]
        public long? TargetableID { get; set; } = null;

        [JsonProperty("targetable_type")]
        public string TargetableType { get; set; } = null;

        [JsonProperty("appointment_attendees_attributes")]
        public List<AppointmentAttendees> AppointmentAttendeesAttributes { get; set; } = null;

        [JsonProperty("success")]
        public string Success { get; set; } = null;
    }
}
