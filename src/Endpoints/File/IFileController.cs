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
        Task<FileModel> CreateLink(IFilePayload body, string include = null, int? page = null);

        Task<FileModel> GetAllFilesAndLinksByID(long id, string include = null, int? page = null);
    }
}
