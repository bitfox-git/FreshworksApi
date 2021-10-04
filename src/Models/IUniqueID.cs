using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Models
{
    public interface IUniqueID
    {
        [JsonProperty("id")]
        long ID { get; set; }
    }

    
}
