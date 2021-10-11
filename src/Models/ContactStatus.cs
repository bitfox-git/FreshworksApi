﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class ContactStatus
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("position")]
        public int? Position { get; set; } = null;

        [JsonProperty("partial")]
        public bool? Partial { get; set; } = null;

        [JsonProperty("forecast_type")]
        public string ForecastType { get; set; } = null;

        [JsonProperty("lifecycle_stage_id")]
        public long? LifecycleStageID { get; set; } = null;
    }
}
