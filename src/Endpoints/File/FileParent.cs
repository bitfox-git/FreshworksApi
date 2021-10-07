using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public class FileParent : ErrorObject
    {
        [JsonProperty("users")]
        public List<User> Users { get; set; } = null;

        [JsonProperty("documents")]
        public List<FileModel> Documents { get; set; } = null;

        [JsonProperty("document_links")]
        public List<FileModel> DocumentLinks { get; set; } = null;
    }
}
