using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class TaskController//: BaseController<ITaskPayload, TaskParent>, ITaskController
    {
        public TaskController(string baseURL, string apikey) //: base($"{baseURL}/api/tasks", apikey)
        { }

        //// Get All Tasks
        //public async Task<TaskParent> GetAllByFilter(string filter, Params _params = null)
        //{
        //    if (_params == null)
        //    {
        //        _params = new Params();
        //    }
        //    _params.Filter = filter;
        //    string path = _params.AddPath("");
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await GetApiRequest<TaskParent>(path, hasIncludes);
        //}

        //// Mark Task
        //public async Task<TaskParent> UpdateMarkByID(long id, ITaskPayload body, Params _params=null)
        //{
        //    string path = $"/{id}";
        //    path = _params == null ? path : _params.AddPath(path);
        //    bool hasIncludes = _params != null && _params.Includes != null;

        //    return await UpdateApiRequest<ITaskPayload, TaskParent>(path, body, hasIncludes);
        //}
    }
}
