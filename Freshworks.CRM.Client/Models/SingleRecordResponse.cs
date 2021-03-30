﻿namespace Freshworks.CRM.Client.Models
{


    class SingleRecordResponse<T>
    {
        [JsonPropertyNameBasedOnSingularNameOfT()]
        public T item { get; set; }
    }

}
