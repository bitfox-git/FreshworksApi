using Bitfox.Freshworks.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Models
{
    public class Views
    {
        [JsonProperty("views")]
        public List<View> Content { get; set; }
    }
}
