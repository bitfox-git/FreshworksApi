﻿using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.EndpointFilters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    [EndpointName("/api/documents")]
    public class File : IHasInsertForm
    {
        [JsonProperty("id")]
        public long? ID { get; set; } = null;

        [JsonProperty("url")]
        public string URL { get; set; } = null;

        [JsonProperty("msg")]
        public string Message { get; set; } = null;

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; } = null;

        [JsonProperty("name")]
        public string Name { get; set; } = null;

        [JsonProperty("is_shared")]
        public bool? IsShared { get; set; } = null;

        [JsonProperty("content_file_size")]
        public int? ContentFileSize { get; set; } = null;

        [JsonProperty("content_content_type")]
        public string ContentContentType { get; set; } = null;

        [JsonProperty("content_updated_at")]
        public DateTime? ContentUpdatedAt { get; set; } = null;

        [JsonProperty("content_file_size_readable")]
        public string ContentFileSizeReadable { get; set; } = null;

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        [JsonProperty("is_attached")]
        public bool? IsAttached { get; set; } = null;

        [JsonProperty("creater_id")]
        public long? CreaterID { get; set; } = null;


        public string FilePath { get; set; } = null;

        public string NewFileName { get; set; } = null;

        public long? TargetableID { get; set; } = null;

        public string TargetableType { get; set; } = null;

        public void CatchInsertFormExceptions()
        {
            List<string> exceptions = new();

            if (FilePath == null)
            {
                exceptions.Add("Required key `FilePath` is missing.");
            }

            if (NewFileName == null)
            {
                exceptions.Add("Required key `NewFileName` is missing.");
            }

            if (IsShared == null)
            {
                exceptions.Add("Required key `IsShared` is missing.");
            }

            if (TargetableID == null)
            {
                exceptions.Add("Required key `TargetableID` is missing.");
            }

            if (TargetableType == null)
            {
                exceptions.Add("Required key `TargetableType` is missing.");
            }

            if (exceptions.Count > 0)
            {
                throw new MissingFieldException(string.Join("\n", exceptions));
            }

        }

    }
}