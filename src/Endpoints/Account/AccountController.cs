using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    public class AccountController : BaseController<AccountPayload, AccountModel>, IAccountController
    {
        public AccountController(string BaseURL, string apikey) : base($"{BaseURL}/api/sales_accounts", apikey)
        { }
    }
}
