﻿using Bitfox.Freshworks.NetworkModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface INotePayload
    {
        [JsonProperty("note")]
        NoteModel Note { get; set; }
    }
}