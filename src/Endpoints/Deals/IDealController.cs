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
        /// Create a item added to the rest of the content
        /// </summary>
        /// <param name="payload">Model used to create a item with.</param>
        Task<DealParent> Create(IDealPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Get all items from given ID.
        /// </summary>
        /// <param name="id">Content ID</param>
        Task<DealParent> GetAllByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Get Data from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        Task<DealParent> GetByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Update data of item from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        /// <param name="payload">Payload used to update item</param>
        Task<DealParent> UpdateByID(long id, IDealPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Remove Item from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        Task<bool> DeleteByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Clone a deal by using his ID.
        /// </summary>
        /// <param name="id">ID of deal, to copy from</param>
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
