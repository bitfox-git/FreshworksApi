using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class SelectorModel
    {

        [JsonProperty("partial")]
        public bool Partial { get; set; }

        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("exchange_rate")]
        public string ExchangeRate { get; set; }

        [JsonProperty("currency_type")]
        public int CurrencyType { get; set; }

        [JsonProperty("schedule_info")]
        public string ScheduleInfo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("contact_status_ids")]
        public List<long> ContactStatusIDs { get; set; }

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

        [JsonProperty("lifecycle_stage_id")]
        public long LifecycleStageID { get; set; } = default;

        [JsonProperty("sales_activity_type_id")]
        public long SalesActivityTypeID { get; set; } = default;

        [JsonProperty("sales_activity_type_name")]
        public string SalesActivityTypeName { get; set; } = default;

    }
}
