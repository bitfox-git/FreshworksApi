using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface IAccount
    {
        /// <summary>
        /// Include data to this model.
        /// </summary>
        /// <param name="include">name of table</param>
        IQuery Include(string include);

        /// <summary>
        /// Get Account Fields
        /// </summary>
        Task<Result<T>> GetAllFields<T>() where T : IHasFields;

        /// <summary>
        /// Get Account Filters
        /// </summary>
        Task<Result<T>> FetchAll<T>() where T : IHasFilters;

        /// <summary>
        /// Insert a new account item.
        /// </summary>
        /// <typeparam name="T">Account class get endpoint from</typeparam>
        /// <param name="body">New account account payload</param>
        Task<Result<T>> Insert<T>(T body) where T : IHasInsert;

        /// <summary>
        /// Get A Account on ID
        /// </summary>
        /// <typeparam name="T">Account class get endpoint from</typeparam>
        /// <param name="body">New account account payload</param>
        Task<Result<T>> GetByID<T>(T body) where T : IHasView, IHasUniqueID;

        /// <summary>
        /// Get A Account on ID
        /// </summary>
        /// <typeparam name="T">Account class get endpoint from</typeparam>
        /// <param name="id">Account ID</param>
        Task<Result<T>> GetByID<T>(long id) where T : IHasView;

        /// <summary>
        /// Get All Accounts on ID
        /// </summary>
        /// <typeparam name="T">Account class get endpoint from</typeparam>
        /// <param name="body">New account account payload</param>
        Task<Result<T>> GetAllByID<T>(T body) where T : IHasAllView<T>, IHasUniqueID;

        /// <summary>
        /// Get All Accounts on ID
        /// </summary>
        /// <typeparam name="T">Account class get endpoint from</typeparam>
        /// <param name="id">Account ID</param>
        Task<Result<T>> GetAllByID<T>(long id) where T : IHasAllView<T>;

        /// <summary>
        /// Update account information on account ID.
        /// </summary>
        /// <param name="body">Account ID and content used for update</param>
        Task<Result<T>> Update<T>(T body) where T : IHasUpdate;

        /// <summary>
        /// Clone account by using his ID.
        /// </summary>
        /// <param name="body">Account ID and content used for cloning</param>
        Task<Result<T>> Clone<T>(T body) where T : IHasClone;

        /// <summary>
        /// Remove account by account ID.
        /// </summary>
        /// <param name="body">Account ID</param>
        Task<Result<bool>> Delete<T>(T body) where T : IHasDelete;

        /// <summary>
        /// Remove account by account ID.
        /// </summary>
        /// <param name="id">Account ID</param>
        Task<Result<bool>> Delete<T>(long id) where T : IHasDelete;

        /// <summary>
        /// Hard delete a account and all the associated data.
        /// </summary>
        /// <param name="body">Account contains ID that will been deleted</param>
        Task<Result<bool>> Forget<T>(T body) where T : IHasForget;

        /// <summary>
        /// Hard delete a account and all the associated data.
        /// </summary>
        /// <param name="id">ID that will been deleted</param>
        Task<Result<bool>> Forget<T>(long id) where T : IHasForget;

        /// <summary>
        /// Delete Accounts in bulk.
        /// </summary>
        /// <param name="body">Account contains needed data for deletion</param>
        Task<Result<T>> DeleteBulk<T>(T body) where T : IHasDeleteBulk;

    }
}
