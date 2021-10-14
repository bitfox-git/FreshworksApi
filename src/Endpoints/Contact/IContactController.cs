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
        /// Insert a new contact item.
        /// </summary>
        /// <param name="payload">New contact account payload</param>
        Task<ContactParent> Create(IContactPayload payload, Params _params=null);

        /// <summary>
        /// Get all contact information from given user ID.
        /// </summary>
        /// <param name="id">User ID</param>
        Task<ContactParent> GetAllByID(long id, Params _params = null);

        /// <summary>
        /// Get contact information from contact ID.
        /// </summary>
        /// <param name="id">Contact ID</param>
        Task<ContactParent> GetByID(long id, Params _params = null);

        /// <summary>
        /// Update contact information on contact ID.
        /// </summary>
        /// <param name="id">Contact ID</param>
        /// <param name="payload">Payload used to update contact</param>
        Task<ContactParent> UpdateByID(long id, IContactPayload payload, Params _params = null);

        /// <summary>
        /// Remove contact by contact ID.
        /// </summary>
        /// <param name="id">Contact ID</param>
        Task<bool> DeleteByID(long id, Params _params = null);

        /// <summary>
        /// Clone contact by contact ID.
        /// </summary>
        /// <param name="id">Contact ID</param>
        /// <param name="body">Content that will been updated</param>
        Task<ContactParent> CloneByID(long id, IContactPayload body, Params _params = null);

        /// <summary>
        /// Hard delete a contact and all the associated data.
        /// </summary>
        /// <param name="id">Given ID will been deleted</param>
        Task<bool> ForgetByID(long id, Params _params = null);

        /// <summary>
        /// Assign an owner to a list of contacts
        /// </summary>
        /// <param name="body">Owner ID and contact IDs</param>
        Task<ContactParent> CreateBulk(BulkAssign body, Params _params = null);

        /// <summary>
        /// Delete contacts in bulk.
        /// </summary>
        /// <param name="body">Contact IDs</param>
        Task<ContactParent> DeleteBulk(BulkDelete body, Params _params = null);

        /// <summary>
        /// View all the contact fields.
        /// </summary>
        Task<ContactParent> GetAllFields(string path = "/../settings/contacts/fields", Params _params = null);

        /// <summary>
        /// Get the activities of a contact.
        /// </summary>
        /// <param name="id">ID of contact</param>
        Task<ContactParent> GetAllActivitiesByID(long id, Params _params = null);
    }
}
