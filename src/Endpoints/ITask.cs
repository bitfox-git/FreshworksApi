using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface ITask
    {
        /// <summary>
        /// Include data to this model.
        /// </summary>
        /// <param name="include">name of table</param>
        IQuery Include(string include);

        /// <summary>
        /// Insert a new task item.
        /// </summary>
        /// <param name="body">New task item payload</param>
        Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert;

        /// <summary>
        /// Get content from task information.
        /// </summary>
        IQuery Query();

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
