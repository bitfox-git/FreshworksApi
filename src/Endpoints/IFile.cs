using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface IFile
    {
        /// <summary>
        /// Include data to this model.
        /// </summary>
        /// <param name="include">name of table</param>
        IQuery Include(string include);

        /// <summary>
        /// Insert item into database.
        /// </summary>
        /// <typeparam name="T">Type of item and response</typeparam>
        /// <param name="item">Item that needs to insert</param>
        Task<Result<T>> Insert<T>(T item) where T : IHasInsert;

        /// <summary>
        /// Insert item into database.
        /// </summary>
        /// <typeparam name="T">Type of item and response</typeparam>
        /// <param name="item">Item that needs to insert</param>
        Task<Result<T>> InsertForm<T>(T item) where T : IHasInsertForm;

        /// <summary>
        /// Get all activities by ID.
        /// </summary>
        /// <typeparam name="T">File model only</typeparam>
        /// <param name="body">File to get ID from</param>
        Task<Result<T>> GetAllActivitiesByID<T>(T body) where T : IHasActivities, IHasUniqueID;

        /// <summary>
        /// Get all activities by ID.
        /// </summary>
        /// <typeparam name="T">File model only</typeparam>
        /// <param name="id">File to get ID from</param>
        Task<Result<T>> GetAllActivitiesByID<T>(long? id) where T : IHasActivities;

        /// <summary>
        /// Get File Filters
        /// </summary>
        Task<Result<T>> FetchAll<T>() where T : IHasFilters;
    }
}
