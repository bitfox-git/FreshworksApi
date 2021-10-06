using Bitfox.Freshworks.NetworkModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class ContactPortal: BasePortal<ContactObject, ContactObject, ContactModel>
    {
        public ContactPortal(string baseURL, string apikey) : base($"{baseURL}/api/contacts", apikey)
        { }

        // Clone a user
        public async Task<ContactModel> CloneByID(long id, ContactObject body, string include=null, int? page=null)
        {
            var path = SetParams($"/{id}/clone", include, page);
            return await PostApiRequest<ContactObject, ContactModel>(path, body);
        }

        // Forget a user
        public async Task<bool> ForgetByID(long id, string include=null, int? page=null)
        {
            var path = SetParams($"/{id}/forget", include, page);
            return await DeleteApiRequest(path);
        }

        // Bulk Assign user
        public async Task<ContactModel> CreateBulk(BulkAssignObject body, string include = null, int? page=null)
        {
            var path = SetParams($"/bulk_assign_owner", include, page);
            return await PostApiRequest<BulkAssignObject, ContactModel>(path, body);
        }

        // Bulk delete contacts
        public async Task<ContactModel> DeleteBulk(BulkDeleteObject body, string include = null, int? page=null)
        {
            var path = SetParams($"/bulk_destroy", include, page);
            return await PostApiRequest<BulkDeleteObject, ContactModel>(path, body);
        }

        // List all contact fields
        public async Task<ContactModel> GetAllFields(string include = null, int? page = null)
        {
            var path = SetParams($"/../settings/contacts/fields", include, page);
            return await GetApiRequest<ContactModel>(path);
        }

        // List all activities
        public async Task<ContactModel> GetAllActivitiesByID(long id, string include = null, int? page = null)
        {
            var path = SetParams($"/{id}/activities.json", include, page);
            return await GetApiRequest<ContactModel>(path);
        }
    }
}
