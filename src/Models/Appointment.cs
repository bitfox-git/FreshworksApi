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
        [JsonProperty("conferences")]
        public List<Conference> Conferences { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;

        [JsonReturnParentProperty]
        [JsonProperty("success")]
        public string Success { get; set; } = null;

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

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; } = null;

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; } = null;

        [JsonProperty("provider")]
        public string Provider { get; set; } = null;

        [JsonProperty("latitude")]
        public string Latitude { get; set; } = null;

        [JsonProperty("longitude")]
        public string Longitude { get; set; } = null;

        [JsonProperty("checkedin_at")]
        public string CheckedinAt { get; set; } = null;

        [JsonProperty("can_checkin_checkout")]
        public bool? CanCheckinCheckout { get; set; } = null;

        [JsonProperty("checkedout_latitude")]
        public string CheckedoutLatitude { get; set; } = null;

        [JsonProperty("checkedout_longitude")]
        public string CheckedoutLongitude { get; set; } = null;

        [JsonProperty("checkedout_location")]
        public string CheckedoutLocation { get; set; } = null;

        [JsonProperty("checkedout_at")]
        public string CheckedoutAt { get; set; } = null;

        [JsonProperty("checkedin_duration")]
        public string CheckedinDuration { get; set; } = null;

        [JsonProperty("can_checkin")]
        public bool? CanCheckin { get; set; } = null;

        [JsonProperty("conference_id")]
        public long? ConferenceID { get; set; } = null;

        [JsonProperty("appointment_attendee_ids")]
        public List<long> AppointmentAttendeeIDs { get; set; } = null;

        [JsonProperty("note_id")]
        public long? NoteID { get; set; } = null;

        [JsonProperty("location")]
        public string Location { get; set; } = null;

        [JsonProperty("is_allday")]
        public bool? IsAllday { get; set; } = null;

        [JsonProperty("outcome_id")]
        public long? OutcomeID { get; set; } = null;

        [JsonProperty("targetable")]
        public string Targetable { get; set; } = null;

        [JsonProperty("targetable_id")]
        public long? TargetableID { get; set; } = null;

        [JsonProperty("targetable_type")]
        public string TargetableType { get; set; } = null;

        [JsonProperty("appointment_attendees_attributes")]
        public List<Attendee> AppointmentAttendeesAttributes { get; set; } = null;


        public void CatchDeleteExceptions()
        {
            List<string> exceptions = new();

            if (ID == null)
            {
                exceptions.Add("Required key `ID` is missing.");
            }

            if (exceptions.Count > 0)
            {
                throw new MissingFieldException(string.Join("\n", exceptions));
            }
        }

        public void CatchInsertExceptions()
        {
            List<string> exceptions = new();

            if (Title == null)
            {
                exceptions.Add("Required key `Title` is missing.");
            }

            if (FromDate == null)
            {
                exceptions.Add("Required key `FromDate` is missing.");
            }

            if (EndDate == null)
            {
                exceptions.Add("Required key `EndDate` is missing.");
            }

            if (exceptions.Count > 0)
            {
                throw new MissingFieldException(string.Join("\n", exceptions));
            }
        }

        public void CatchUpdateExceptions()
        {
            List<string> exceptions = new();

            if (ID == null)
            {
                exceptions.Add("Required key `ID` is missing.");
            }

            if (exceptions.Count > 0)
            {
                throw new MissingFieldException(string.Join("\n", exceptions));
            }
        }
    }
}
