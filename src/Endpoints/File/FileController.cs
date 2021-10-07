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
    public class FileController: BaseController<FilePayload, FileModel>, IFileController
    {
        public FileController(string baseURL, string apikey) : base($"{baseURL}/api", apikey)
        { }

        // Create a link
        public async Task<FileModel> CreateLink(FilePayload body)
        {
            var path = $"/document_links";
            return await PostApiRequest<FilePayload, FileModel>(path, body);
        }

        // List all Files and Links
        public async Task<FileModel> GetAllFilesAndLinksByID(long id)
        {
            var path = $"/contacts/{id}/document_associations";
            return await GetApiRequest<FileModel>(path);
        }






    }
}
