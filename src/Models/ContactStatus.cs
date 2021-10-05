using Newtonsoft.Json;

namespace Bitfox.Freshworks.Models
{
    public class ContactStatus: IUniqueID
    {
        //{
        //    "id": 17000261979,
        //    "name": "Contacted",
        //    "position": 2,
        //    "partial": true,
        //    "forecast_type": "Open",
        //    "lifecycle_stage_id": 18004287484
        //},

        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("partial")]
        public bool Partial { get; set; }

        [JsonProperty("forecast_type")]
        public string ForecastType { get; set; }

        [JsonProperty("lifecycle_stage_id")]
        public long LifecycleStageID { get; set; }
    }
}
