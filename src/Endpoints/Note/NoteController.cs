using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    public class NoteController: BaseController<INotePayload, NoteParent>, INoteController
    {
        public NoteController(string BaseURL, string apikey): base($"{BaseURL}/api/notes", apikey)
        { }

        // Delete Note
        public async Task<NoteParent> DeleteNoteByID(long id, Params _params = null)
        {
            var path = $"/{id}";
            path = _params == null ? path : _params.AddPath($"/{id}");
            bool hasIncludes = _params != null && _params.Includes != null;

            return await DeleteApiRequest<NoteParent>(path, hasIncludes);
        }

    }
}
