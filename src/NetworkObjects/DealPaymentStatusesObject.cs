using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkObjects
{
    public class DealPaymentStatusesObject : ErrorObject
    {
        [JsonProperty("deal_payment_statuses")]
        public List<DealStage> PaymentStatuses { get; set; } = null;
    }
}
