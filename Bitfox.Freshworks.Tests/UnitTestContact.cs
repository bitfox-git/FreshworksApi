using Bitfox.Freshworks.Endpoints.Contact;
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
        private readonly ITestOutputHelper _console;
        private readonly ICRMClient _client;
        private readonly UnitTestSelectors _selectors;

        public UnitTestContact(ITestOutputHelper console, ClientFixture clientFixture)
        {
            _console = console;
            _client = clientFixture.Client;
            _selectors = new UnitTestSelectors(console, clientFixture);
        }

        [Fact]
        public async Task InsertContactOnSuccess()
        {
            Contact contact = await CreateContact();

            _ = await RemoveContact(contact);
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

            _ = await RemoveContact(contact);
        }

        [Fact]
        public async Task GetContactByIDAndIncludesOnSuccess()
        {
            Contact contact = await GetContactByIDAndSelectors();

            _ = await RemoveContact(contact.Item);
        }

        [Fact]
        public async Task GetAllContactsByIDOnSuccess()
        {
            _ = await GetAllContactsByID();
        }

        [Fact]
        public async Task UpdateContactOnSuccess()
        {
            Contact contact = await CreateContact();

            contact = await UpdateContact(contact);

            _ = await RemoveContact(contact);
        }

        [Fact]
        public async Task CloneContactOnSuccess()
        {
            var contact = await CreateContact();
            var clonedContact = await CloneContact(contact);

            _ = await RemoveContact(contact);
            _ = await RemoveContact(clonedContact);

        }

        [Fact]
        public async Task DeleteContactOnSuccess()
        {
            // get Contact
            Contact contact = await CreateContact();

            _ = await RemoveContact(contact);
        }

        [Fact]
        public async Task ForgetContactOnSuccess()
        {
            Contact contact = await CreateContact();

            _ = await ForgetContact(contact);
        }

        [Fact]
        public async Task AssignBulkContactOnSuccess()
        {
            var owners = await _client.Query().GetOwners();
            var owner = (owners.Content as List<User>)[0];

            Contact contact = await CreateContact();
            contact.OwnerID = owner.ID;

            _ = await AssignContactBulk(contact);
            _ = await RemoveContact(contact);
        }

        [Fact]
        public async Task DeleteBulkContactOnSuccess()
        {
            var owners = await _client.Query().GetOwners();
            var owner = (owners.Content as List<User>)[0];

            Contact contact = await CreateContact();
            contact.OwnerID = owner.ID;

            Contact delete = new()
            {
                SelectedIDs = new List<long> { (long)contact.ID }
            };

            _ = await AssignContactBulk(contact);
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






        private async Task<Contact> CreateContact()
        {
            string name = GetCurrentTime()
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
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content as Contact;
        }

        private async Task<Contact> GetContactFilters()
        {
            var result = await _client.FetchAll<Contact>();
            //var result = await _client.Contact.FetchAll<Contact>();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Contact;

        }

        private async Task<bool> RemoveContact(Contact contact)
        {
            // execute
            var result = await _client.Delete(contact);
            //var result = await _client.Contact.Delete(contact);
            //var result = await _client.Delete<Contact>(contact.ID);
            //var result = await _client.Contact.Delete<Contact>(contact.ID);

            Assert.True((bool)result.Content);
            return (bool)result.Content;
        }

        private async Task<Contact> GetContactByID()
        {
            var Contact = await CreateContact();

            // exucute get Contact
            var result = await _client.Query().GetByID(Contact);
            //var result = await _client.Query().GetByID<Contact>(Contact.ID);
            //var result = await _client.Contact.Query().GetByID(Contact);
            //var result = await _client.Contact.Query().GetByID<Contact>(Contact.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Contact;
        }

        private async Task<Contact> GetContactByIDAndSelectors()
        {
            // create Contact
            var content = await CreateContact();
            Contact contact = new() { ID = content.ID };

            // exucute get Contact
            var result = await _client.Query()
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
            Assert.NotNull(result.Content);
            Assert.NotNull(result.Includes);
            return GetResponse(result) as Contact;
        }

        private async Task<Contact> GetAllContactsByID()
        {
            // get Contact
            var filters = await GetContactFilters();
            var content = filters.Filters[0];
            Contact contact = new() { ID = content.ID };

            // execute
            var result = await _client.Query().GetAllByID(contact);
            //var result = await _client.Query().GetAllByID<Contact>(content.ID);
            //var result = await _client.Contact.Query().GetAllByID(Contact);
            //var result = await _client.Contact.Query().GetAllByID<Contact>(content.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Contact;
        }

        private async Task<Contact> UpdateContact(Contact contact)
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
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Contact;
        }

        private async Task<Contact> CloneContact(Contact contact)
        {
            string name = GetCurrentTime()
                .Replace(" ", "")
                .Replace("/", "")
                .Replace(":", "");

            Contact newContact = new()
            {
                ID = contact.ID,
                FirstName = $"TEST Clone Name:({GetCurrentTime()})",
                Email = $"{name}@gmail.com"
            };

            // Commands
            var result = await _client.Clone(newContact);
            //var result = await _client.Contact.Clone(newContact);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Contact;
        }

        private async Task<bool> ForgetContact(Contact Contact)
        {
            // execute
            var result = await _client.Forget(Contact);
            //var result = await _client.Contact.Forget(Contact);
            //var result = await _client.Forget<Contact>(Contact.ID);
            //var result = await _client.Contact.Forget<Contact>(Contact.ID);

            Assert.True((bool)result.Content);
            return (bool)result.Content;
        }

        private async Task<string> AssignContactBulk(Contact contact)
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
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content as string;
        }

        private async Task<string> DeleteContactBulk(Contact contact)
        {
            Contact bulk = new()
            {
                SelectedIDs = contact.SelectedIDs
            };

            // Commands
            var result = await _client.DeleteBulk(bulk);
            //var result = await _client.Contact.DeleteBulk(bulk);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return result.Content as string;
        }

        public async Task<Contact> AllContactFields()
        {
            // Commands
            var result = await _client.Query().GetAllFields<Contact>();
            //var result = await _client.Contact.Query().GetAllFields<Contact>();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Contact;
        }

        private object GetResponse<TEntity>(Result<TEntity> result)
        {
            if (result.Content != null)
            {
                _console.WriteLine($"The result content type: {result.Content.GetType()}");
                return result.Content;
            }
            else
            {
                _console.WriteLine($"The result error message: {result.Error.Message}");
                return null;
            }
        }

        private static string GetCurrentTime()
        {
            return DateTime.Now.ToString();
        }
        
    }
}
