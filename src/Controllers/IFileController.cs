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
        Task<FileModel> CreateLink(FilePayload body);

        Task<FileModel> GetAllFilesAndLinksByID(long id);
    }
}
