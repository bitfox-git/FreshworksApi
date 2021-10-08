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
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<TaskParent> Create(ITaskPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Get all tasks information from given user ID.
        /// </summary>
        /// <param name="id">User ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<TaskParent> GetAllByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Get task information from task ID.
        /// </summary>
        /// <param name="id">Task ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<TaskParent> GetByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Update task information on task ID.
        /// </summary>
        /// <param name="id">Task ID</param>
        /// <param name="payload">Payload used to update task</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<TaskParent> UpdateByID(long id, ITaskPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Remove Task by task ID.
        /// </summary>
        /// <param name="id">Task ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<bool> DeleteByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Mark a task as done.
        /// </summary>
        /// <param name="id">Task ID</param>
        /// <param name="payload">Status code sample: {"task": {"status" :1} </param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        /// <returns></returns>
        Task<TaskParent> UpdateMarkByID(long id, ITaskPayload payload, string include = null, int? page = null);
    }
}
