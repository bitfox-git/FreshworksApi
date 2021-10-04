using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class CurrencySelectionResponse: IUniqueID
    {
        //{
        //    "partial": true,
        //    "id": 17000029017,
        //    "is_active": true,
        //    "currency_code": "USD",
        //    "exchange_rate": "1.0",
        //    "currency_type": 1,
        //    "schedule_info": null
        //}

        [JsonProperty("partial")]
        public bool Partial { get; set; }

        [JsonProperty("id")]
        public long ID { get; set; }

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
    }
}
