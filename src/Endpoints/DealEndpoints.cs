using Bitfox.Freshworks.NetworkModels;
using Bitfox.Freshworks.NetworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class DealsPortal : BasePortal<DealObject, DealObject, DealModel>
    {
        public DealsPortal(string baseURL, string apikey) : base($"{baseURL}/api/deals", apikey)
        { }


        // Clone a user
        public async Task<DealModel> CloneByID(long id, DealObject body, string include = null, int? page = null)
        {
            var path = SetParams($"/{id}/clone", include, page);
            return await PostApiRequest<DealObject, DealModel>(path, body);
        }

        // Forget a user
        public async Task<bool> ForgetByID(long id, string include = null, int? page = null)
        {
            var path = SetParams($"/{id}/forget", include, page);
            return await DeleteApiRequest(path);
        }

        // Bulk delete contacts
        public async Task<ContactModel> DeleteBulk(BulkDeleteObject body, string include = null, int? page = null)
        {
            var path = SetParams($"/bulk_destroy", include, page);
            return await PostApiRequest<BulkDeleteObject, ContactModel>(path, body);
        }

        // List all contact fields
        public async Task<ContactModel> GetAllFields(string include = null, int? page = null)
        {
            var path = SetParams($"/../settings/deals/fields", include, page);
            return await GetApiRequest<ContactModel>(path);
        }


    }
}
