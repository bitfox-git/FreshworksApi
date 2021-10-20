using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    public interface IAccountController
    {
        /// <summary>
        /// Insert a new account item.
        /// </summary>
        /// <param name="body">New account account payload</param>
        Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert;

        /// <summary>
        /// Get Account Filters
        /// </summary>
        Task<Result<TEntity>> FetchAll<TEntity>() where TEntity : IHasFilters;

        /// <summary>
        /// Get content from account information.
        /// </summary>
        Query Query();

        /// <summary>
        /// Update account information on account ID.
        /// </summary>
        /// <param name="body">Account ID and content used for update</param>
        Task<Result<TEntity>> Update<TEntity>(TEntity body) where TEntity : IHasUpdate;

        /// <summary>
        /// Clone account by using his ID.
        /// </summary>
        /// <param name="body">Account ID and content used for cloning</param>
        Task<Result<TEntity>> Clone<TEntity>(TEntity body) where TEntity : IHasClone;

        /// <summary>
        /// Remove account by account ID.
        /// </summary>
        /// <param name="body">Account ID</param>
        Task<Result<bool>> Delete<TEntity>(TEntity body) where TEntity : IHasDelete;

        /// <summary>
        /// Remove account by account ID.
        /// </summary>
        /// <param name="id">Account ID</param>
        Task<Result<bool>> Delete<TEntity>(long? id) where TEntity : IHasDelete;

        /// <summary>
        /// Hard delete a account and all the associated data.
        /// </summary>
        /// <param name="body">Account contains ID that will been deleted</param>
        Task<Result<bool>> Forget<TEntity>(TEntity body) where TEntity : IHasForget;

        /// <summary>
        /// Hard delete a account and all the associated data.
        /// </summary>
        /// <param name="id">ID that will been deleted</param>
        Task<Result<bool>> Forget<TEntity>(long? id) where TEntity : IHasForget;

        /// <summary>
        /// Delete Accounts in bulk.
        /// </summary>
        /// <param name="body">Account contains needed data for deletion</param>
        Task<Result<TEntity>> DeleteBulk<TEntity>(TEntity body) where TEntity : IHasDeleteBulk;
    }
}
