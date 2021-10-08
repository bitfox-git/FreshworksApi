using Bitfox.Freshworks.Endpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    public interface IFileController
    {
        /// <summary>
        /// Create a new file link item.
        /// </summary>
        /// <param name="payload">New file link payload</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<FileModel> CreateLink(IFilePayload payload, string include = null, int? page = null);


        /// <summary>
        /// Get all Files and links from given user account.
        /// </summary>
        /// <param name="id">User ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<FileModel> GetAllFilesAndLinksByID(long id, string include = null, int? page = null);
    }
}
