using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints.Selector
{
    public interface ISelectorController
    {
        /// <summary>
        /// Get all owners from this subdomain
        /// </summary>
        Task<Result<Selector>> GetOwners();



    }
}
