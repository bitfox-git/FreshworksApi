using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Bitfox.Freshworks.Tests
{
    [Collection("Client Collection")]
    public class UnitTestContact
    {
        private readonly ICRMClient _client;

        public UnitTestContact(ClientFixture clientFixture)
        {
            _client = clientFixture.Client;
        }

        [Fact]
        public async Task InsertContactOnSuccess()
        {
            Contact contact = await CreateContact();

            _ = await RemoveContact(contact.Contact);
        }

        [Fact]
        public async Task GetContactFiltersOnSuccess()
        {
            _ = await GetContactFilters();
        }

        [Fact]
        public async Task GetContactByIDOnSuccess()
        {
            Contact contact = await GetContactByID();

            _ = await RemoveContact(contact.Contact);
        }

        [Fact]
        public async Task GetContactByIDAndIncludesOnSuccess()
        {
            Contact contact = await GetContactByIDAndSelectors();

            _ = await RemoveContact(contact.Contact);
        }

        [Fact]
        public async Task GetAllContactsByIDOnSuccess()
        {
            // get Contact
            var filters = await GetContactFilters();
            var content = filters.Filters[0];
            Contact contact = new() { ID = content.ID };

            // execute
            var result = await _client.GetAllByID(contact);
            //var result = await _client.Query().GetAllByID<Contact>(content.ID);
            //var result = await _client.Contact.Query().GetAllByID(Contact);
            //var result = await _client.Contact.Query().GetAllByID<Contact>(content.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async Task UpdateContactOnSuccess()
        {
            Contact contact = await CreateContact();

            contact = await UpdateContact(contact.Contact);

            _ = await RemoveContact(contact.Contact);
        }

        [Fact]
        public async Task CloneContactOnSuccess()
        {
            var contact = await CreateContact();

            var clonedContact = await CloneContact(contact.Contact);

            _ = await RemoveContact(contact.Contact);
            
            _ = await RemoveContact(clonedContact.Contact);

        }

        [Fact]
        public async Task DeleteContactOnSuccess()
        {
            // get Contact
            Contact contact = await CreateContact();

            _ = await RemoveContact(contact.Contact);
        }

        [Fact]
        public async Task ForgetContactOnSuccess()
        {
            Contact contact = await CreateContact();

            _ = await ForgetContact(contact.Contact);
        }

        [Fact]
        public async Task AssignBulkContactOnSuccess()
        {
            var owners = await _client.GetOwners();
            var owner = (owners.Value as Selector).Users[0];

            Contact contact = await CreateContact();
            contact.Contact.OwnerID = owner.ID;

            _ = await AssignContactBulk(contact.Contact);
            _ = await RemoveContact(contact.Contact);
        }

        [Fact]
        public async Task DeleteBulkContactOnSuccess()
        {
            var owners = await _client.GetOwners();
            var owner = (owners.Value as Selector).Users[0];

            Contact contact = await CreateContact();
            contact.Contact.OwnerID = owner.ID;

            Contact delete = new()
            {
                SelectedIDs = new List<long> { (long)contact.Contact.ID }
            };

            _ = await AssignContactBulk(contact.Contact);
            _ = await DeleteContactBulk(delete);
        }

        [Fact]
        public async Task AllContactActivitiesOnSuccess()
        {
            _ = await AllContactFields();
        }

        [Fact]
        public async Task AllContactFieldsOnSuccess()
        {
            _ = await AllContactFields();
        }

        public async Task<Contact> CreateContact()
        {
            string name = DateTime.Now.ToString()
                .Replace(" ", "")
                .Replace("/", "")
                .Replace(":", "");

            Contact contact = new()
            {
                Email = $"EMAIL_{name}@test.com"
            };

            // execute creation
            var result = await _client.Insert(contact);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            
            return result.Value as Contact;
        }

        public async Task<Contact> GetContactFilters()
        {
            var result = await _client.FetchAll<Contact>();
            //var result = await _client.Contact.FetchAll<Contact>();

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            
            return result.Value as Contact;

        }

        public async Task<bool> RemoveContact(Contact contact)
        {
            // execute
            var result = await _client.Delete(contact);
            //var result = await _client.Contact.Delete(contact);
            //var result = await _client.Delete<Contact>(contact.ID);
            //var result = await _client.Contact.Delete<Contact>(contact.ID);

            Assert.True((bool)result.Value);
            return (bool)result.Value;
        }

        public async Task<Contact> GetContactByID()
        {
            var contact = await CreateContact();

            // exucute get Contact
            var result = await _client.GetByID(contact.Contact);
            //var result = await _client.GetByID<Contact>(contact.Contact.ID);
            //var result = await _client.Contact.GetByID(contact.Contact);
            //var result = await _client.Contact.GetByID<Contact>(contact.Contact.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            return result.Value as Contact;
        }

        public async Task<Contact> GetContactByIDAndSelectors()
        {
            // create Contact
            var content = await CreateContact();
            Contact contact = new() { ID = content.Contact.ID };

            // exucute get Contact
            var result = await _client
                .Include("owner")
                .Include("creater")
                .Include("updater")
                .Include("territory")
                .Include("business_type")
                .Include("tasks")
                .Include("appointments")
                .Include("contacts")
                .Include("deals")
                .Include("industry_type")
                .Include("child_sales_Contacts")
                .GetByID(contact);
            //var result = await _client.Query().Include("owner").GetByID<Contact>(contact.ID);
            //var result = await _client.Contact.Query().Include("owner").GetByID(contact);
            //var result = await _client.Contact.Query().Include("owner").GetByID<Contact>(contact.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            return result.Value as Contact;
        }


        public async Task<Contact> UpdateContact(Contact contact)
        {
            Contact newContact = new()
            {
                ID = contact.ID,
                FirstName = $"TEST Random Name"
            };

            // execute
            var result = await _client.Update(newContact);
            //var result = await _client.Contact.Update(newContact);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            
            return result.Value as Contact;
        }

        public async Task<Contact> CloneContact(Contact contact)
        {
            string name = DateTime.Now.ToString()
                .Replace(" ", "")
                .Replace("/", "")
                .Replace(":", "");

            Contact newContact = new()
            {
                ID = contact.ID,
                FirstName = $"TEST Clone Name:({DateTime.Now})",
                Email = $"{name}@gmail.com"
            };

            // Commands
            var result = await _client.Clone(newContact);
            //var result = await _client.Contact.Clone(newContact);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            
            return result.Value as Contact;
        }

        public async Task<bool> ForgetContact(Contact Contact)
        {
            // execute
            var result = await _client.Forget(Contact);
            //var result = await _client.Contact.Forget(Contact);
            //var result = await _client.Forget<Contact>(Contact.ID);
            //var result = await _client.Contact.Forget<Contact>(Contact.ID);

            Assert.True((bool)result.Value);
            return (bool)result.Value;
        }

        public async Task<Contact> AssignContactBulk(Contact contact)
        {
            Contact bulk = new()
            {
                SelectedIDs = new List<long> { (long)contact.ID },
                OwnerID = contact.OwnerID
            };

            // Commands
            var result = await _client.AssignBulk(bulk);
            //var result = await _client.Contact.AssignBulk(bulk);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            
            return result.Value;
        }

        public async Task<Contact> DeleteContactBulk(Contact contact)
        {
            Contact bulk = new()
            {
                SelectedIDs = contact.SelectedIDs
            };

            // Commands
            var result = await _client.DeleteBulk(bulk);
            //var result = await _client.Contact.DeleteBulk(bulk);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            
            return result.Value;
        }

        public async Task<Contact> AllContactFields()
        {
            // Commands
            var result = await _client.GetAllFields<Contact>();
            //var result = await _client.Contact.GetAllFields<Contact>();

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            
            return result.Value as Contact;
        }
        
    }
}
