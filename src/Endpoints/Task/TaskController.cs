using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class TaskController: BaseController<TaskPayload, TaskModel>, ITaskController
    {
        public TaskController(string baseURL, string apikey) : base($"{baseURL}/api/tasks", apikey)
        { }

        // Mark Task
        public async Task<TaskModel> UpdateMarkByID(long id, TaskPayload body)
        {
            var path = $"/{id}";
            return await UpdateApiRequest<TaskPayload, TaskModel>(path, body);
        }
    }
}
