using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;

namespace Bitfox.Freshworks.Endpoints
{
    public class NoteParent: ErrorObject
    {

        [JsonProperty("note")]
        public NoteModel Note { get; set; } = null;

    }
}