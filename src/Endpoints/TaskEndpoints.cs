using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class TaskEndpoints: BasePortal<TaskObject, TaskObject, TaskModel>
    {
        public TaskEndpoints(string baseURL, string apikey) : base($"{baseURL}/api/tasks", apikey)
        { }

        // Mark Task
        public async Task<TaskModel> UpdateMarkByID(long id, TaskObject body, string include = null, int? page = null)
        {
            var path = SetParams($"/{id}", include, page);
            return await UpdateApiRequest<TaskObject, TaskModel>(path, body);
        }

        // Delete Task
        public async Task<bool> DeleteMarkByID(long id, string include = null, int? page = null)
        {
            var path = SetParams($"/{id}", include, page);
            return await DeleteApiRequest(path);
        }

    }
}
