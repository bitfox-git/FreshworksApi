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
    public class SalesPayload: ErrorObject
    {
        [JsonProperty("sales_activity")]
        public SalesModel Activity { get; set; } = null;
    }
}
