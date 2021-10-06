using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class AccountPortal: BasePortal<AccountObject, AccountObject, AccountModel>
    {
        public AccountPortal(string baseURL, string apikey): base ($"{baseURL}/api/sales_accounts", apikey)
        { }

        // Clone a account
        public async Task<AccountModel> CloneByID(long id, AccountObject body, string include = null, int? page = null)
        {
            var path = SetParams($"/{id}/clone", include, page);
            return await PostApiRequest<AccountObject, AccountModel>(path, body);
        }

        // Forget a account
        public async Task<bool> ForgetByID(long id, string include = null, int? page = null)
        {
            var path = SetParams($"/{id}/forget", include, page);
            return await DeleteApiRequest(path);
        }

        // Bulk delete accounts
        public async Task<AccountModel> DeleteBulk(AccountBulkDeleteObject body, string include = null, int? page = null)
        {
            var path = SetParams($"/bulk_destroy", include, page);
            return await PostApiRequest<AccountBulkDeleteObject, AccountModel>(path, body);
        }

        // List all account fields
        public async Task<AccountModel> GetAllFields(string include = null, int? page = null)
        {
            var path = SetParams($"/../settings/sales_accounts/fields", include, page);
            return await GetApiRequest<AccountModel>(path);
        }
    }
}
