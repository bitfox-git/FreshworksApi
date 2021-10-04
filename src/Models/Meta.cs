﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Models
{


    public class Meta
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
        
        [JsonProperty("total")]
        public int Total { get; set;  }
    }
}
