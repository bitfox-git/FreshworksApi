using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public class NotePayload : ErrorObject
    {
        [JsonProperty("note")]
        public NoteModel Note { get; set; } = null;
    }
}
