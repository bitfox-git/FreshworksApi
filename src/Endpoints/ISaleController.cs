using Bitfox.Freshworks.Endpoints.Sales;
using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    public interface ISaleController
    {
        /// <summary>
        /// Insert a new Sales item.
        /// </summary>
        /// <param name="body">New appointment item payload</param>
        Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert<TEntity>, new();

        /// <summary>
        /// Get content from Sales information.
        /// </summary>
        Query Query();

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
