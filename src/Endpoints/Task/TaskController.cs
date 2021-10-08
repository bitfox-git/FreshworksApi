using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class TaskController: BaseController<ITaskPayload, TaskParent>, ITaskController
    {
        public TaskController(string baseURL, string apikey) : base($"{baseURL}/api/tasks", apikey)
        { }

        // Mark Task
        public async Task<TaskParent> UpdateMarkByID(long id, ITaskPayload body, Params _params=null)
        {
            string path = $"/{id}";
            path = _params == null ? path : _params.AddPath(path);
            return await UpdateApiRequest<ITaskPayload, TaskParent>(path, body);
        }
    }
}
