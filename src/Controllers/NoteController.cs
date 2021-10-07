using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    public class NoteController: BaseController<NotePayload, NoteModel>, INoteController
    {
        public NoteController(string BaseURL, string apikey): base($"{BaseURL}/api/notes", apikey)
        { }

        // Delete Note
        public async Task<NoteModel> DeleteNoteByID(long id)
        {
            var path = SetParams($"/{id}");
            return await DeleteApiRequest<NoteModel>(path);
        }

    }
}
