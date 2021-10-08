﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class TaskUserAttribute
    {
        [JsonProperty("user_id")]
        public string UserID { get; set; } = null;
    }
}