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
        /// Insert a new task item.
        /// </summary>
        /// <param name="body">New task item payload</param>
        Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert;

        /// <summary>
        /// Get content from task information.
        /// </summary>
        Query Query();

        /// <summary>
        /// Update task information on task ID.
        /// </summary>
        /// <param name="body">Tasks ID and Tasks used for update</param>
        Task<Result<TEntity>> Update<TEntity>(TEntity body) where TEntity : IHasUpdate;

        /// <summary>
        /// Remove task by task ID.
        /// </summary>
        /// <param name="body">Tasks ID</param>
        Task<Result<bool>> Delete<TEntity>(TEntity body) where TEntity : IHasDelete;

        /// <summary>
        /// Remove task by task ID.
        /// </summary>
        /// <param name="id">Tasks ID</param>
        Task<Result<bool>> Delete<TEntity>(long? id) where TEntity : IHasDelete;

    }
}
