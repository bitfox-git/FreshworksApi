﻿using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkObjects
{
    public class AppointmentObject
    {
        [JsonProperty("appointment")]
        public AppointmentModel Appointment { get; set; } = null;
    }
}
