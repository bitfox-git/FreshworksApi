using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints.Appointment
{
    [EndpointName("/api/appointments")]
    public class Appointment: Includes, IHasInsert, IHasView, IHasUpdate, IHasDelete, IHasFilters, IHasUniqueID
    {
        [JsonReturnParentProperty]
        [JsonProperty("appointment")]
        public Appointment Item { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("appointment_attendees")]
        public List<Attendee> AppointmentAttendees { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;

        // Childs

        [JsonProperty("id")]
        public long? ID { get; set; } = null;

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
        public List<Attendee> AppointmentAttendeesAttributes { get; set; } = null;

        [JsonProperty("success")]
        public string Success { get; set; } = null;

        public void CatchInsertExceptions()
        {
            throw new NotImplementedException();
        }

        public void CatchUpdateExceptions()
        {
            throw new NotImplementedException();
        }
    }
}
