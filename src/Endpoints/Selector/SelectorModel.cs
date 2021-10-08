using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bitfox.Freshworks.Models
{
    public class SelectorModel
    {

        [JsonProperty("partial")]
        public bool? Partial { get; set; } = null;

        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("is_active")]
        public bool? IsActive { get; set; } = null;

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; } = null;

        [JsonProperty("exchange_rate")]
        public string ExchangeRate { get; set; } = null;

        [JsonProperty("currency_type")]
        public int? CurrencyType { get; set; } = null;

        [JsonProperty("schedule_info")]
        public string ScheduleInfo { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("position")]
        public int? Position { get; set; } = null;

        [JsonProperty("disabled")]
        public bool? Disabled { get; set; } = null;

        [JsonProperty("default")]
        public bool? Default { get; set; } = null;

        [JsonProperty("type")]
        public string Type { get; set; } = null;

        [JsonProperty("contact_status_ids")]
        public List<long> ContactStatusIDs { get; set; } = null;

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
        public long? LifecycleStageID { get; set; } = null;

        [JsonProperty("sales_activity_type_id")]
        public long? SalesActivityTypeID { get; set; } = null;

        [JsonProperty("sales_activity_type_name")]
        public string SalesActivityTypeName { get; set; } = null;

    }
}
