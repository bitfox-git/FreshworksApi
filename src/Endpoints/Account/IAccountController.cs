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
        Task<Result<TEntity>> GetFilters<TEntity>() where TEntity : IHasFilters;

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

        //    /// <summary>
        //    /// Get account information from account ID.
        //    /// </summary>
        //    /// <param name="id">Account ID</param>
        //    Task<AccountModel> GetByID(long id, Params _params = null);


        //    /// <summary>
        //    /// Get account information from account ID.
        //    /// </summary>
        //    /// <param name="id">Account ID</param>
        //    Task<AccountModel> GetAllByID(long id, Params _params = null);


        //    /// <summary>
        //    /// Remove account by account ID.
        //    /// </summary>
        //    /// <param name="id">Account ID</param>
        //    Task<bool> DeleteByID(long id, Params _params=null);

        //    /// <summary>
        //    /// Hard delete a account and all the associated data.
        //    /// </summary>
        //    /// <param name="id">Given ID will been deleted</param>
        //    Task<bool> ForgetByID(long id, Params _params=null);


        //    /// <summary>
        //    /// View all the account fields.
        //    /// </summary>
        //    Task<AccountModel> GetAllFields(string path = "/../settings/contacts/fields", Params _params=null);

    }

    //public interface IAccountController
    //{

    //    /// <summary>
    //    /// Get account information from account ID.
    //    /// </summary>
    //    /// <param name="id">Account ID</param>
    //    Task<AccountModel> GetByID(long id, Params _params = null);


    //    /// <summary>
    //    /// Get account information from account ID.
    //    /// </summary>
    //    /// <param name="id">Account ID</param>
    //    Task<AccountModel> GetAllByID(long id, Params _params = null);


    //    /// <summary>
    //    /// Update account information on account ID.
    //    /// </summary>
    //    /// <param name="id">Account ID</param>
    //    /// <param name="payload">Payload used to update account</param>
    //    Task<AccountModel> UpdateView(long id, AccountModel payload, Params _params = null);


    //    ///// <summary>
    //    ///// Insert a new account item.
    //    ///// </summary>
    //    ///// <param name="payload">New account account payload</param>
    //    //Task<AccountParent> Insert(IAccountPayload payload, Params _params=null);

    //    ///// <summary>
    //    ///// Get all accounts from given user ID.
    //    ///// </summary>
    //    ///// <param name="id">User ID</param>
    //    //Task<AccountModel> GetAllByID(long id, Params _params=null);

    //    ///// <summary>
    //    ///// Get account information from account ID.
    //    ///// </summary>
    //    ///// <param name="id">Account ID</param>
    //    //Task<AccountModel> GetByID(long id, Params _params=null);

    //    ///// <summary>
    //    ///// Update account information on account ID.
    //    ///// </summary>
    //    ///// <param name="id">Account ID</param>
    //    ///// <param name="payload">Payload used to update account</param>
    //    //Task<AccountParent> UpdateByID(long id, IAccountPayload payload, Params _params=null);

    //    /// <summary>
    //    /// Remove account by account ID.
    //    /// </summary>
    //    /// <param name="id">Account ID</param>
    //    Task<bool> DeleteByID(long id, Params _params=null);

    //    /// <summary>
    //    /// Clone account by using his ID.
    //    /// </summary>
    //    /// <param name="id">Account ID</param>
    //    /// <param name="body">Content that will been updated</param>
    //    Task<AccountModel> CloneByID(long id, AccountModel body, Params _params=null);

    //    /// <summary>
    //    /// Hard delete a account and all the associated data.
    //    /// </summary>
    //    /// <param name="id">Given ID will been deleted</param>
    //    Task<bool> ForgetByID(long id, Params _params=null);

    //    /// <summary>
    //    /// Delete Accounts in bulk.
    //    /// </summary>
    //    /// <param name="body">Account IDs</param>
    //    Task<AccountModel> DeleteBulk(BulkDelete body, Params _params=null);

    //    /// <summary>
    //    /// View all the account fields.
    //    /// </summary>
    //    Task<AccountModel> GetAllFields(string path = "/../settings/contacts/fields", Params _params=null);

    //}
}
