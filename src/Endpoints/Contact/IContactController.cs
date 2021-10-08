using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Endpoints.Contact;
using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    public interface IContactController
    {
        /// <summary>
        /// Create a new contact item.
        /// </summary>
        /// <param name="payload">New contact account payload</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<ContactParent> Create(IContactPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Get all contact information from given user ID.
        /// </summary>
        /// <param name="id">User ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<ContactParent> GetAllByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Get contact information from contact ID.
        /// </summary>
        /// <param name="id">Contact ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<ContactParent> GetByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Update contact information on contact ID.
        /// </summary>
        /// <param name="id">Contact ID</param>
        /// <param name="payload">Payload used to update contact</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<ContactParent> UpdateByID(long id, IContactPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Remove contact by contact ID.
        /// </summary>
        /// <param name="id">Contact ID</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<bool> DeleteByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Clone contact by contact ID.
        /// </summary>
        /// <param name="id">Contact ID</param>
        /// <param name="body">Content that will been updated</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<ContactParent> CloneByID(long id, IContactPayload body, string include = null, int? page = null);

        /// <summary>
        /// Hard delete a contact and all the associated data.
        /// </summary>
        /// <param name="id">Given ID will been deleted</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<bool> ForgetByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Assign an owner to a list of contacts
        /// </summary>
        /// <param name="body">Owner ID and contact IDs</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<ContactParent> CreateBulk(BulkAssign body, string include = null, int? page = null);

        /// <summary>
        /// Delete contacts in bulk.
        /// </summary>
        /// <param name="body">Contact IDs</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<ContactParent> DeleteBulk(BulkDelete body, string include = null, int? page = null);

        /// <summary>
        /// View all the contact fields.
        /// </summary>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<ContactParent> GetAllFields(string path="/../settings/contacts/fields", string include = null, int? page = null);

        /// <summary>
        /// Get the activities of a contact.
        /// </summary>
        /// <param name="id">ID of contact</param>
        /// <param name="include">Add extra content by response</param>
        /// <param name="page">Limit response size</param>
        Task<ContactParent> GetAllActivitiesByID(long id, string include = null, int? page = null);
    }
}
