using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    public interface ISalesController
    {
        /// <summary>
        /// Create a new sale item.
        /// </summary>
        /// <param name="payload">New sale payload</param>
        Task<SalesParent> Create(ISalesPayload payload, Params _params=null);

        /// <summary>
        /// Get all sales information from given user ID.
        /// </summary>
        /// <param name="id">User ID</param>
        Task<SalesParent> GetAllByID(long id, Params _params=null);

        /// <summary>
        /// Get sale information from sale ID.
        /// </summary>
        /// <param name="id">Sale ID</param>
        Task<SalesParent> GetByID(long id, Params _params=null);

        /// <summary>
        /// Update sale information on sale ID.
        /// </summary>
        /// <param name="id">Sale ID</param>
        /// <param name="payload">Payload used to update sale</param>
        Task<SalesParent> UpdateByID(long id, ISalesPayload payload, Params _params=null);

        /// <summary>
        /// Remove Sale by using sale ID.
        /// </summary>
        /// <param name="id">Sale ID</param>
        Task<bool> DeleteByID(long id, Params _params=null);
    }
}
