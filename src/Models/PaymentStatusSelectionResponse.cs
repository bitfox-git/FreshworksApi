using Newtonsoft.Json;

namespace Bitfox.Freshworks.Models
{
    public class PaymentStatusSelectionResponse: IUniqueID
    {
        //{
        //    "id": 17000057563,
        //    "name": "Online",
        //    "position": 2,
        //    "partial": true
        //}

        [JsonProperty("id")]
        public long ID { get; set; }


        [JsonProperty("name")]
        public string Name { get; set; }


        [JsonProperty("position")]
        public int Position { get; set; }


        [JsonProperty("partial")]
        public bool Partial { get; set; }
    }
}
