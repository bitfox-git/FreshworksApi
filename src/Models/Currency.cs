using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Currency
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("partial")]
        public bool? Partial { get; set; } = null;

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
    }
}
