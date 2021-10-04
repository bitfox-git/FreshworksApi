using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Selectors
{

    [EndpointName("deal_payment_statuses")]
    public class DealPaymentStatuses : ISelector
    {
        [JsonProperty("deal_payment_statuses")]
        public List<PaymentStatusSelectionResponse> PaymentStatuses { get; set; }
    }
}
