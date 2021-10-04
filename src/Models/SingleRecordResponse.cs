using Bitfox.Freshworks.Attributes;
using Newtonsoft.Json;

namespace Bitfox.Freshworks.Models
{

    class SingleRecordResponse<T>
    {
        //[JsonPropertyNameBasedOnSingularNameOfT()]
        [JsonProperty("item")]
        public T Item { get; set; }

        [JsonProperty("errors")]
        public Error Errors { get; set; }
    }

}
