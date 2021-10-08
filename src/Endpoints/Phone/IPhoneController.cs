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
        /// <param name="body">Payload model sended</param>
        /// <returns></returns>
        Task<PhoneParent> GetCallLogs(IPhonePayload body, string include = null, int? page = null);
    }
}
