namespace Freshworks.CRM.Client.Models
{
    public class ListResponse<T>
    {

        [JsonPropertyNameBasedOnPluralNameOfT()]
        public T[] items { get; set; }

        public Meta meta { get; set; }

        public Error errors { get; set; }
    }

}
