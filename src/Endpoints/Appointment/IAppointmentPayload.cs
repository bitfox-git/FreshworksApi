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
    public interface IAppointmentPayload
    {
        [JsonProperty("appointment")]
        AppointmentModel Appointment { get; set; }
    }
}
