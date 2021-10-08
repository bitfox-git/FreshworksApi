using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public class FileController: BaseController<IFilePayload, FileParent>, IFileController
    {
        public FileController(string baseURL, string apikey) : base($"{baseURL}/api", apikey)
        { }

        // Create a link
        public async Task<FileParent> CreateLink(IFilePayload body, Params _params=null)
        {
            string path = $"/document_links";
            path = _params == null ? path : _params.AddPath(path);
            return await PostApiRequest<IFilePayload, FileParent>(path, body);
        }

        // List all Files and Links
        public async Task<FileParent> GetAllFilesAndLinksByID(long id, Params _params=null)
        {
            string path = $"/contacts/{id}/document_associations";
            path = _params == null ? path : _params.AddPath(path);
            return await GetApiRequest<FileParent>(path);
        }






    }
}
