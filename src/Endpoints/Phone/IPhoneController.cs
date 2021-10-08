using Bitfox.Freshworks.Endpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    public interface IPhoneController
    {
        /// <summary>
        /// Log all calls that are been made.
        /// </summary>
        /// <param name="payload">Data from who we log the calls</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<PhoneParent> GetCallLogs(IPhonePayload payload, string include = null, int? page = null);
    }
}
