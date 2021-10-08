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
        /// Create a item added to the rest of the content
        /// </summary>
        /// <param name="payload">Model used to create a item with.</param>
        Task<AccountParent> Create(IAccountPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Get all items from given ID.
        /// </summary>
        /// <param name="id">Content ID</param>
        Task<AccountParent> GetAllByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Get Data from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        Task<AccountParent> GetByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Update data of item from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        /// <param name="payload">Payload used to update item</param>
        Task<AccountParent> UpdateByID(long id, IAccountPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Remove Item from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        Task<bool> DeleteByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Clone account by using his ID.
        /// </summary>
        /// <param name="id">ID of account, to copy from</param>
        /// <param name="body">Content that can been updated</param>
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
