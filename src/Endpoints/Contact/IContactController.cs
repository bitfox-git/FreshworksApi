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
        /// Create a item added to the rest of the content
        /// </summary>
        /// <param name="payload">Model used to create a item with.</param>
        Task<ContactParent> Create(IContactPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Get all items from given ID.
        /// </summary>
        /// <param name="id">Content ID</param>
        Task<ContactParent> GetAllByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Get Data from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        Task<ContactParent> GetByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Update data of item from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        /// <param name="payload">Payload used to update item</param>
        Task<ContactParent> UpdateByID(long id, IContactPayload payload, string include = null, int? page = null);

        /// <summary>
        /// Remove Item from given ID.
        /// </summary>
        /// <param name="id">Item ID</param>
        Task<bool> DeleteByID(long id, string include = null, int? page = null);

        /// <summary>
        /// Clone contact by using his ID.
        /// </summary>
        /// <param name="id">ID of contact, to copy from</param>
        /// <param name="body">Content that can been updated</param>
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
