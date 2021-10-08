using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;

namespace Bitfox.Freshworks.Endpoints
{
    public class NoteParent: ErrorObject, INotePayload
    {
        [JsonProperty("note")]
        public NoteModel Note { get; set; } = null;
    }
}