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
        Task<DealParent> Create(IDealPayload payload, Params _params=null);

        /// <summary>
        /// Get all deal informations from given user ID.
        /// </summary>
        /// <param name="id">User ID</param>
        Task<DealParent> GetAllByID(long id, Params _params=null);

        /// <summary>
        /// Get deal information from deal ID.
        /// </summary>
        /// <param name="id">Deal ID</param>
        Task<DealParent> GetByID(long id, Params _params=null);

        /// <summary>
        /// Update deal information on deal ID.
        /// </summary>
        /// <param name="id">Deal ID</param>
        /// <param name="payload">Payload used to update item</param>
        Task<DealParent> UpdateByID(long id, IDealPayload payload, Params _params=null);

        /// <summary>
        /// Remove contact by contact ID.
        /// </summary>
        /// <param name="id">Deal ID</param>
        Task<bool> DeleteByID(long id, Params _params=null);

        /// <summary>
        /// Clone a deal by using his ID.
        /// </summary>
        /// <param name="id">Deal ID</param>
        /// <param name="body">Content that can been updated</param>
        Task<DealParent> CloneByID(long id, IDealPayload body, Params _params=null);

        /// <summary>
        /// Hard delete a Deal and all the associated data.
        /// </summary>
        /// <param name="id">Given ID will been deleted</param>
        Task<bool> ForgetByID(long id, Params _params=null);

        /// <summary>
        /// Delete deals in bulk.
        /// </summary>
        /// <param name="body">Contact IDs</param>
        Task<DealParent> DeleteBulk(BulkDelete body, Params _params=null);

        /// <summary>
        /// View all the deal fields.
        /// </summary>
        Task<DealParent> GetAllFields(string path = "/../settings/deals/fields", Params _params=null);
    }
}
