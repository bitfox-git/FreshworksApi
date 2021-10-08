using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;

namespace Bitfox.Freshworks.Endpoints
{
    public class NoteParent: ErrorObject, INotePayload, IIncludes
    {
        [JsonProperty("note")]
        public NoteModel Note { get; set; } = null;

        public IncludesParent Includes { get; set; } = null;
    }
}