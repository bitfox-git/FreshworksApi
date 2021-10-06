using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class ContactPortal: BasePortal<ContactModel>
    {
        public ContactPortal(string baseURL, string apikey): base($"{baseURL}/api/contacts", apikey)
        { }

        // REST 


        // Bulk Assign user
        public async Task<Result<ContactModel>> BulkAssignOwner(ContactModel body)
        {
            var url = $"{BaseURL}/bulk_assign_owner";
            return await PostApiRequest(url, ApiKey, body);
        }

        // Clone a user
        public async Task<Result<ContactModel>> CloneContact(long contactID, ContactModel body)
        {
            var url = $"{BaseURL}/{contactID}/clone";
            return await PostApiRequest(url, ApiKey, body);
        }

        // Forget a user
        public async Task<bool> ForgetContact(long contactID)
        {
            var url = $"{BaseURL}/{contactID}/forget";
            return await DeleteApiRequest(url, ApiKey);
        }

        // Bulk delete contacts
        public async Task<Result<ContactModel>> BulkDeleteContacts(ContactModel body)
        {
            var url = $"{BaseURL}/bulk_destroy";
            return await PostApiRequest(url, ApiKey, body);
        }

        // List all contact fields
        public async Task<ContactModel> ListAllContactFields(long contactID)
        {
            var url = $"{BaseURL}/{contactID}/activities.json";
            return await GetApiRequest<ContactModel>(url, ApiKey);
        }

        // List all activities
        // public async Task<ContactModel> ListAllActivities(long contactID)
        // {
        //     var url = $"{BaseURL}/{contactID}/activities.json";
        //    return await GetApiRequest<ContactModel>(url, ApiKey);
        //}
    }
}
