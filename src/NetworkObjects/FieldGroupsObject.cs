using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.NetworkModels
{
    public class FieldGroupsObject : ErrorObject
    {
        [JsonProperty("field_groups")]
        public List<FieldGroupObject> FieldGroup { get; set; } = null;
    }
}
