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
        public async Task<NoteParent> DeleteNoteByID(long id, string include = null, int? page = null)
        {
            var path = SetParams($"/{id}", include, page);
            return await DeleteApiRequest<NoteParent>(path);
        }

    }
}
