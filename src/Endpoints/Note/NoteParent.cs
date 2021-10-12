using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;

namespace Bitfox.Freshworks.Endpoints
{
    public class NoteParent: BaseResponse, INotePayload
    {
        [JsonProperty("note")]
        public NoteModel Note { get; set; } = null;

        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;

        [JsonProperty("success")]
        public string Success { get; set; } = null;
    }
}