using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface ISale
    {
        /// <summary>
        /// Include data to this model.
        /// </summary>
        /// <param name="include">name of table</param>
        IQuery Include(string include);

        /// <summary>
        /// Insert a new Sales item.
        /// </summary>
        /// <param name="body">New appointment item payload</param>
        Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert;

        /// <summary>
        /// Get content from Sales information.
        /// </summary>
        IQuery Query();

        /// <summary>
        /// Update Sales information on Sales ID.
        /// </summary>
        /// <param name="body">Sales ID and Sales used for update</param>
        Task<Result<TEntity>> Update<TEntity>(TEntity body) where TEntity : IHasUpdate;

        /// <summary>
        /// Remove Sales by Sales ID.
        /// </summary>
        /// <param name="body">Sales ID</param>
        Task<Result<bool>> Delete<TEntity>(TEntity body) where TEntity : IHasDelete;

        /// <summary>
        /// Remove Sales by Sales ID.
        /// </summary>
        /// <param name="id">Sales ID</param>
        Task<Result<bool>> Delete<TEntity>(long? id) where TEntity : IHasDelete;
    }
}
