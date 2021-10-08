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
        /// Create a new account item.
        /// </summary>
        /// <param name="payload">New account account payload</param>
        Task<AccountParent> Create(IAccountPayload payload, Params _params=null);

        /// <summary>
        /// Get all accounts from given user ID.
        /// </summary>
        /// <param name="id">User ID</param>
        Task<AccountParent> GetAllByID(long id, Params _params=null);

        /// <summary>
        /// Get account information from account ID.
        /// </summary>
        /// <param name="id">Account ID</param>
        Task<AccountParent> GetByID(long id, Params _params=null);

        /// <summary>
        /// Update account information on account ID.
        /// </summary>
        /// <param name="id">Account ID</param>
        /// <param name="payload">Payload used to update account</param>
        Task<AccountParent> UpdateByID(long id, IAccountPayload payload, Params _params=null);

        /// <summary>
        /// Remove account by account ID.
        /// </summary>
        /// <param name="id">Account ID</param>
        Task<bool> DeleteByID(long id, Params _params=null);

        /// <summary>
        /// Clone account by using his ID.
        /// </summary>
        /// <param name="id">Account ID</param>
        /// <param name="body">Content that will been updated</param>
        Task<AccountParent> CloneByID(long id, IAccountPayload body, Params _params=null);

        /// <summary>
        /// Hard delete a account and all the associated data.
        /// </summary>
        /// <param name="id">Given ID will been deleted</param>
        Task<bool> ForgetByID(long id, Params _params=null);

        /// <summary>
        /// Delete Accounts in bulk.
        /// </summary>
        /// <param name="body">Account IDs</param>
        Task<AccountParent> DeleteBulk(BulkDelete body, Params _params=null);

        /// <summary>
        /// View all the account fields.
        /// </summary>
        Task<AccountParent> GetAllFields(string path = "/../settings/contacts/fields", Params _params=null);

    }
}
