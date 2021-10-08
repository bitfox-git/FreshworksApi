using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    public interface IDealController
    {
        /// <summary>
        /// Create a new deal item.
        /// </summary>
        /// <param name="payload">New deal item payload</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<DealParent> Create(IDealPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Get all deal informations from given user ID.
        /// </summary>
        /// <param name="id">User ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<DealParent> GetAllByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Get deal information from deal ID.
        /// </summary>
        /// <param name="id">Deal ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<DealParent> GetByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Update deal information on deal ID.
        /// </summary>
        /// <param name="id">Deal ID</param>
        /// <param name="payload">Payload used to update item</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<DealParent> UpdateByID(long id, IDealPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Remove contact by contact ID.
        /// </summary>
        /// <param name="id">Deal ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<bool> DeleteByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Clone a deal by using his ID.
        /// </summary>
        /// <param name="id">Deal ID</param>
        /// <param name="body">Content that can been updated</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<DealParent> CloneByID(long id, IDealPayload body, string include = null, int? page = null);

        /// <summary>
        /// Hard delete a Deal and all the associated data.
        /// </summary>
        /// <param name="id">Given ID will been deleted</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<bool> ForgetByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Delete deals in bulk.
        /// </summary>
        /// <param name="body">Contact IDs</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<DealParent> DeleteBulk(BulkDelete body, string include = null, int? page = null);

        /// <summary>
        /// View all the deal fields.
        /// </summary>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<DealParent> GetAllFields(string path = "/../settings/deals/fields", string include = null, int? page = null);
    }
}
