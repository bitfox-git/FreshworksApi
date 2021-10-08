using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    public interface INoteController
    {

        /// <summary>
        /// Create a new note item.
        /// </summary>
        /// <param name="payload">Model used to create a item with.</param>
        Task<NoteParent> Create(INotePayload payload, Params _params=null);

        /// <summary>
        /// Update note by note ID.
        /// </summary>
        /// <param name="id">Note ID</param>
        /// <param name="payload">Payload used to update note</param>
        Task<NoteParent> UpdateByID(long id, INotePayload payload, Params _params=null);

        /// <summary>
        /// Remove note by note ID.
        /// </summary>
        /// <param name="id">Note ID</param>
        Task<NoteParent> DeleteNoteByID(long id, Params _params=null);
    }
}
