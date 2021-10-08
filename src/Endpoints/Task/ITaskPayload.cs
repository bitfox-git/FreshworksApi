using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkObjects
{
    public interface ITaskPayload
    {
        [JsonProperty("task")]
        TaskModel Task { get; set; }
    }
}
