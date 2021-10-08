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
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<AccountParent> Create(IAccountPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Get all accounts from given user ID.
        /// </summary>
        /// <param name="id">User ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<AccountParent> GetAllByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Get account information from account ID.
        /// </summary>
        /// <param name="id">Account ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<AccountParent> GetByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Update account information on account ID.
        /// </summary>
        /// <param name="id">Account ID</param>
        /// <param name="payload">Payload used to update account</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<AccountParent> UpdateByID(long id, IAccountPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Remove account by account ID.
        /// </summary>
        /// <param name="id">Account ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<bool> DeleteByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Clone account by using his ID.
        /// </summary>
        /// <param name="id">Account ID</param>
        /// <param name="body">Content that will been updated</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<AccountParent> CloneByID(long id, IAccountPayload body, string include = null, int? page = null);

        /// <summary>
        /// Hard delete a account and all the associated data.
        /// </summary>
        /// <param name="id">Given ID will been deleted</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<bool> ForgetByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Delete Accounts in bulk.
        /// </summary>
        /// <param name="body">Account IDs</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<AccountParent> DeleteBulk(BulkDelete body, string include = null, int? page = null);

        /// <summary>
        /// View all the account fields.
        /// </summary>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<AccountParent> GetAllFields(string path = "/../settings/contacts/fields", string include = null, int? page = null);

    }
}
