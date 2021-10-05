using Newtonsoft.Json;

namespace Bitfox.Freshworks.Models
{

// SalesActivityOutcome & SalesActivityOutcomesOnID: {
//    "partial": true,
//    "id": 17001056310,
//    "name": "Left message",
//    "sales_activity_type_id": 17000241379,
//    "position": 1
//},

// SalesActivityEntityType: {
//    "partial": true,
//    "id": 17000086530,
//    "name": "Follow up",
//    "sales_activity_type_id": 17000230649,
//    "position": 1,
//    "sales_activity_type_name": "Task"
//},

// SalesActivityType: {
//    "id": 17000261978,
//    "name": "New",
//    "position": 1,
//    "partial": true,
//    "forecast_type": "Open",
//    "lifecycle_stage_id": 18004287484
//}

    public class SalesActivityType
    {

        [JsonProperty("id")]
        public long ID { get; set; } = default;

        [JsonProperty("name")]
        public string Name { get; set; } = default;

        [JsonProperty("position")]
        public int Position { get; set; } = default;

        [JsonProperty("partial")]
        public bool Partial { get; set; } = default;

        [JsonProperty("forecast_type")]
        public string ForecastType { get; set; } = default;

        [JsonProperty("lifecycle_stage_id")]
        public long LifecycleStageID { get; set; } = default;

        [JsonProperty("sales_activity_type_id")]
        public long SalesActivityTypeID { get; set; } = default;

        [JsonProperty("sales_activity_type_name")]
        public string SalesActivityTypeName { get; set; } = default;
    }
}
