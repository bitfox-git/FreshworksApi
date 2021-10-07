using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkObjects
{
    public class TaskPayload
    {
        [JsonProperty("task")]
        public TaskModel Task { get; set; } = null;
    }
}
