using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    public interface ITaskController
    {
        /// <summary>
        /// Create a new task item.
        /// </summary>
        /// <param name="payload">New task payload.</param>
        Task<TaskParent> Create(ITaskPayload payload, Params _params=null);

        /// <summary>
        /// Get all tasks information from given user ID.
        /// </summary>
        /// <param name="id">User ID</param>
        Task<TaskParent> GetAllByID(long id, Params _params=null);

        /// <summary>
        /// Get task information from task ID.
        /// </summary>
        /// <param name="id">Task ID</param>
        Task<TaskParent> GetByID(long id, Params _params=null);

        /// <summary>
        /// Update task information on task ID.
        /// </summary>
        /// <param name="id">Task ID</param>
        /// <param name="payload">Payload used to update task</param>
        Task<TaskParent> UpdateByID(long id, ITaskPayload payload, Params _params=null);

        /// <summary>
        /// Remove Task by task ID.
        /// </summary>
        /// <param name="id">Task ID</param>
        Task<bool> DeleteByID(long id, Params _params=null);

        /// <summary>
        /// Mark a task as done.
        /// </summary>
        /// <param name="id">Task ID</param>
        /// <param name="payload">Status code sample: {"task": {"status" :1} </param>
        Task<TaskParent> UpdateMarkByID(long id, ITaskPayload payload, Params _params=null);
    }
}
