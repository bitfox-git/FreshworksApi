using Bitfox.Freshworks.Attributes;
using Newtonsoft.Json;

namespace Bitfox.Freshworks.Models
{
    public class ListResponse<T>
    {
        //[JsonPropertyNameBasedOnPluralNameOfT()]
        [JsonProperty("items")]
        public T[] Items { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("errors")]
        public Error Errors { get; set; }
    }

}
