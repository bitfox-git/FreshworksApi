using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
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
        Task<PhoneParent> GetCallLogs(IPhonePayload payload, Params _params = null);
    }
}
