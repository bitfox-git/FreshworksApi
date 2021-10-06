using Newtonsoft.Json;
using System.Collections.Generic;

//   DealPipeline: {
//        "partial": true,
//        "id": 17000029663,
//        "name": "null Pipeline",
//        "position": 1,
//        "is_null": true,
//        "rotting_days": 30,
//        "configs": [
//            {
//                "field_name": "amount",
//                "position": 1,
//                "highlight": true
//            }
//        ],
//        "aggregated_field": "expected_deal_value",
//        "deal_stages": [
//            {
//                "id": 17000207787,
//                "value": "New",
//                "name": "New",
//                "position": 1,
//                "forecast_type": "Open",
//                "deal_pipeline_id": 17000029663,
//                "choice_type": 5,
//                "is_deleted": false,
//                "probability": 100,
//                "updated_at": "2021-09-28T09:04:58Z"
//            }
//        ]
//    }

//  DealPipelineByID: {
//      "partial": true,
//      "id": 17000207788,
//      "name": "Follow-up",
//      "position": 2,
//      "forecast_type": "Open",
//      "updated_at": "2021-09-28T09:04:58Z",
//      "deal_pipeline_id": 17000029663,
//      "choice_type": 2,
//      "probability": 100
//  },

//  DealReasons & DealTypes: {
//    "id": 17000259601,
//    "name": "Opted our rival",
//    "position": 1,
//    "partial": true
//  },

//  DealStage: {
//    "partial": true,
//    "id": 17000207787,
//    "name": "New",
//    "position": 1,
//    "forecast_type": "Open",
//    "updated_at": "2021-09-28T09:04:58Z",
//    "deal_pipeline_id": 17000029663,
//    "choice_type": 5,
//    "probability": 100
//    "is_deleted": false
//  }

namespace Bitfox.Freshworks.Models
{
    public class DealStage
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("partial")]
        public bool? Partial { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("position")]
        public int? Position { get; set; } = null;

        [JsonProperty("forecast_type")]
        public string ForecastType { get; set; } = null;

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; } = null;

        [JsonProperty("deal_pipeline_id")]
        public long? DealPipelineID { get; set; } = null;

        [JsonProperty("choice_type")]
        public int? ChoiceType { get; set; } = null;

        [JsonProperty("probability")]
        public int? Probability { get; set; } = null;

        [JsonProperty("rotting_days")]
        public int? RottingDays { get; set; } = null;

        [JsonProperty("configs")]
        public List<Config> Configs { get; set; } = null;

        [JsonProperty("aggregated_field")]
        public string AggregatedField { get; set; } = null;

        [JsonProperty("deal_stages")]
        public List<DealStage> DealStages { get; set; } = null;

        [JsonProperty("is_deleted")]
        public bool? IsDeleted { get; set; } = null;

        [JsonProperty("is_null")]
        public bool? Isnull { get; set; } = null;
    }
}
