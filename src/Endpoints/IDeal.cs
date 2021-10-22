using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface IDeal
    {
        /// <summary>
        /// Query data from database. [ GET ]
        /// </summary>
        IQuery Query { get; }

        /// <summary>
        /// Include data to this model.
        /// </summary>
        /// <param name="include">name of table</param>
        IQuery Include(string include);

        /// <summary>
        /// Insert a new deal item.
        /// </summary>
        /// <param name="body">New deal item payload</param>
        Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert;

        /// <summary>
        /// Update deal information on deal ID.
        /// </summary>
        /// <param name="body">Account ID and content used for update</param>
        Task<Result<TEntity>> Update<TEntity>(TEntity body) where TEntity : IHasUpdate;

        /// <summary>
        /// Clone a deal by using his ID.
        /// </summary>
        /// <param name="body">Account ID and content used for cloning</param>
        Task<Result<TEntity>> Clone<TEntity>(TEntity body) where TEntity : IHasClone;

        /// <summary>
        /// Remove deal by deal ID.
        /// </summary>
        /// <param name="body">Deal ID</param>
        Task<Result<bool>> Delete<TEntity>(TEntity body) where TEntity : IHasDelete;

        /// <summary>
        /// Remove deal by deal ID.
        /// </summary>
        /// <param name="id">Deal ID</param>
        Task<Result<bool>> Delete<TEntity>(long? id) where TEntity : IHasDelete;

        /// <summary>
        /// Hard delete a deal and all the associated data.
        /// </summary>
        /// <param name="body">Deal contains ID that will been deleted</param>
        Task<Result<bool>> Forget<TEntity>(TEntity body) where TEntity : IHasForget;

        /// <summary>
        /// Hard delete a deal and all the associated data.
        /// </summary>
        /// <param name="id">ID that will been deleted</param>
        Task<Result<bool>> Forget<TEntity>(long? id) where TEntity : IHasForget;

        /// <summary>
        /// Delete deals in bulk.
        /// </summary>
        /// <param name="body">Account contains needed data for deletion</param>
        Task<Result<TEntity>> DeleteBulk<TEntity>(TEntity body) where TEntity : IHasDeleteBulk;

    }
}
