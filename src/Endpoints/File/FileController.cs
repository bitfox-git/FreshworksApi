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
        public async Task<FileModel> CreateLink(IFilePayload body, string include = null, int? page = null)
        {
            var path = SetParams($"/document_links", include, page);
            return await PostApiRequest<IFilePayload, FileModel>(path, body);
        }

        // List all Files and Links
        public async Task<FileModel> GetAllFilesAndLinksByID(long id, string include = null, int? page = null)
        {
            var path = SetParams($"/contacts/{id}/document_associations", include, page);
            return await GetApiRequest<FileModel>(path);
        }






    }
}
