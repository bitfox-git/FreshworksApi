using Bitfox.Freshworks.EndpointFilters;
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
        /// Add filters to the response
        /// </summary>
        /// <typeparam name="T">TaskModel</typeparam>
        /// <param name="filter">string filter that we needed</param>
        /// <returns></returns>
        Task<Result<T>> GetAllByFilter<T>(string filter) where T : IHasView;

        /// <summary>
        /// Insert a new task item.
        /// </summary>
        /// <param name="body">New task item payload</param>
        Task<Result<T>> Insert<T>(T body) where T : IHasInsert;

        /// <summary>
        /// Get A Task on ID
        /// </summary>
        /// <typeparam name="T">TaskModel class get endpoint from</typeparam>
        /// <param name="body">New TaskModel payload</param>
        Task<Result<T>> GetByID<T>(T body) where T : IHasView, IHasUniqueID;

        /// <summary>
        /// Get A Task on ID
        /// </summary>
        /// <typeparam name="T">TaskModel class get endpoint from</typeparam>
        /// <param name="id">Task ID</param>
        Task<Result<T>> GetByID<T>(long? id) where T : IHasView;

        /// <summary>
        /// Get All Tasks on ID
        /// </summary>
        /// <typeparam name="T">TaskModel class get endpoint from</typeparam>
        /// <param name="body">New TaskModel payload</param>
        Task<Result<T>> GetAllByID<T>(T body) where T : IHasAllView, IHasUniqueID;

        /// <summary>
        /// Get All Tasks on ID
        /// </summary>
        /// <typeparam name="T">TaskModel class get endpoint from</typeparam>
        /// <param name="id">Task ID</param>
        Task<Result<T>> GetAllByID<T>(long? id) where T : IHasAllView;

        /// <summary>
        /// Update task information on task ID.
        /// </summary>
        /// <param name="body">Tasks ID and Tasks used for update</param>
        Task<Result<T>> Update<T>(T body) where T : IHasUpdate;

        /// <summary>
        /// Remove task by task ID.
        /// </summary>
        /// <param name="body">Tasks ID</param>
        Task<Result<bool>> Delete<T>(T body) where T : IHasDelete;

        /// <summary>
        /// Remove task by task ID.
        /// </summary>
        /// <param name="id">Tasks ID</param>
        Task<Result<bool>> Delete<T>(long? id) where T : IHasDelete;
    }
}
