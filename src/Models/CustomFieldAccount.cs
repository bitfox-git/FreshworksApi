﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class CustomFieldAccount
    {

        [JsonProperty("cf_external_id")]
        public long? ExternalID { get; set; } = null;

        [JsonProperty("cf_email")]
        public string Email { get; set; } = null;

    }
}