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
        Task<DealModel> Create(DealPayload payload);

        /// <summary>
        /// Get all items from given ID.
        /// </summary>
        /// <param name="id">Content ID</param>
        Task<DealModel> GetAllByID(long id);

        /// <summary>
        /// Get Data from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        Task<DealModel> GetByID(long id);

        /// <summary>
        /// Update data of item from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        /// <param name="payload">Payload used to update item</param>
        Task<DealModel> UpdateByID(long id, DealPayload payload);

        /// <summary>
        /// Remove Item from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        Task<bool> DeleteByID(long id);

        /// <summary>
        /// Clone a deal by using his ID.
        /// </summary>
        /// <param name="id">ID of deal, to copy from</param>
        /// <param name="body">Content that can been updated</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<DealModel> CloneByID(long id, DealPayload body, string include = null, int? page = null);

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
        Task<DealModel> DeleteBulk(BulkDeleteObject body, string include = null, int? page = null);

        /// <summary>
        /// View all the deal fields.
        /// </summary>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<DealModel> GetAllFields(string path = "/../settings/deals/fields", string include = null, int? page = null);
    }
}
