namespace Bitfox.Freshworks.Models
{


    class SingleRecordResponse<T>
    {
        [JsonPropertyNameBasedOnSingularNameOfT()]
        public T item { get; set; }

        public Error errors { get; set; }

    }

}
