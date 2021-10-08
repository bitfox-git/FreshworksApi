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
        /// Create a item added to the rest of the content
        /// </summary>
        /// <param name="payload">Model used to create a item with.</param>
        Task<NoteParent> Create(INotePayload payload, string include = null, int? page = null);

        /// <summary>
        /// Update data of item from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        /// <param name="payload">Payload used to update item</param>
        Task<NoteParent> UpdateByID(long id, INotePayload payload, string include = null, int? page = null);

        /// <summary>
        /// Remove Item from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        Task<NoteParent> DeleteNoteByID(long id, string include = null, int? page = null);
    }
}
