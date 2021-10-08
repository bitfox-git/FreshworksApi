using Bitfox.Freshworks.Endpoints;
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
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<NoteParent> Create(INotePayload payload, string include = null, int? page = null);

        /// <summary>
        /// Update note by note ID.
        /// </summary>
        /// <param name="id">Note ID</param>
        /// <param name="payload">Payload used to update note</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<NoteParent> UpdateByID(long id, INotePayload payload, string include = null, int? page = null);

        /// <summary>
        /// Remove note by note ID.
        /// </summary>
        /// <param name="id">Note ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<NoteParent> DeleteNoteByID(long id, string include = null, int? page = null);
    }
}
