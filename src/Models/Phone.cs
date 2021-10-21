using Bitfox.Freshworks.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    [EndpointName("/api/phone_calls")]
    public class Phone: IHasInsert
    {
        [JsonProperty("phone_call")]
        public Phone PhoneCall { get; set; } = null;

        [JsonProperty("phone_calls")]
        public List<Phone> PhoneCalls { get; set; } = null;

        [JsonProperty("phone_numbers")]
        public List<string> PhoneNumbers { get; set; } = null;

        [JsonProperty("phone_callers")]
        public List<string> PhoneCallers { get; set; } = null;

        [JsonProperty("notes")]
        public List<Note> Notes { get; set; } = null;

        [JsonProperty("users")]
        public List<User> Users { get; set; } = null;

        [JsonProperty("outcomes")]
        public List<Outcome> OutComes { get; set; } = null;




        // Childs 

        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("call_duration")]
        public int? CallDuration { get; set; } = null;

        [JsonProperty("recording_duration")]
        public int? RecordingDuration { get; set; } = null;

        [JsonProperty("status")]
        public string Status { get; set; } = null;

        [JsonProperty("recording")]
        public string Recording { get; set; } = null;

        [JsonProperty("conversation_time")]
        public string ConversationTime { get; set; } = null;

        [JsonProperty("cost")]
        public double? Cost { get; set; } = null;

        [JsonProperty("is_manual")]
        public bool? IsManual { get; set; } = null;

        [JsonProperty("root_phone_call_id")]
        public long? RootPhoneCallID { get; set; } = null;

        [JsonProperty("child_phone_calls")]
        public bool? ChildPhoneCalls { get; set; } = null;

        [JsonProperty("outcome_id")]
        public string OutcomeID { get; set; } = null;

        [JsonProperty("source")]
        public string Source { get; set; } = null;

        [JsonProperty("freshcaller_id")]
        public string FreshcallerID { get; set; } = null;

        [JsonProperty("freshcaller_number")]
        public int? FreshcallerNumber { get; set; } = null;

        [JsonProperty("freshcaller_number_country")]
        public string FreshcallerNumberCountry { get; set; } = null;

        [JsonProperty("phone_number_id")]
        public long? PhoneNumberID { get; set; } = null;

        [JsonProperty("phone_caller_id")]
        public long? PhoneCallerID { get; set; } = null;

        [JsonProperty("note_id")]
        public long? NoteID { get; set; } = null;

        [JsonProperty("user_id")]
        public long? UserID { get; set; } = null;

        [JsonProperty("call_direction")]
        public bool? CallDirection { get; set; } = null;

        [JsonProperty("targetable_type")]
        public string TargetableType { get; set; } = null;

        [JsonProperty("targetable")]
        public User Targetable { get; set; } = null;

        [JsonProperty("note")]
        public Note Note { get; set; } = null;


        [JsonProperty("value")]
        public string Value { get; set; } = null;

        [JsonProperty("label")]
        public string Label { get; set; } = null;

        [JsonProperty("_destroy")]
        public bool? Destroy { get; set; } = null;

        public void CatchInsertExceptions()
        { }




    }
}
