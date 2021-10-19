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

            _ = await RemoveContact(contact);
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
            Contact contact = await CreateContact();

            _ = await DeleteContactBulk(contact);
        }

        [Fact]
        public async Task DeleteBulkContactOnSuccess()
        {
            Contact contact = await CreateContact();

            _ = await DeleteContactBulk(contact);
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
            var result = await _client.Filters<Contact>();
            //var result = await _client.Contact.Filters<Contact>();

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
            var Contact = await CreateContact();

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
                .GetByID(Contact);
            //var result = await _client.Query().Include("owner").GetByID<Contact>(Contact.ID);
            //var result = await _client.Contact.Query().Include("owner").GetByID(Contact);
            //var result = await _client.Contact.Query().Include("owner").GetByID<Contact>(Contact.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.NotNull(result.Includes);
            return GetResponse(result) as Contact;
        }

        private async Task<Contact> GetAllContactsByID()
        {
            // get Contact
            var filters = await GetContactFilters();
            var content = filters.Contacts[0];
            Contact Contact = new() { ID = content.ID };

            // execute
            var result = await _client.Query().GetAllByID(Contact);
            //var result = await _client.Query().GetAllByID<Contact>(content.ID);
            //var result = await _client.Contact.Query().GetAllByID(Contact);
            //var result = await _client.Contact.Query().GetAllByID<Contact>(content.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Contact;
        }

        private async Task<Contact> UpdateContact(Contact Contact)
        {
            Contact.DisplayName = $"TEST Random Name:({GetCurrentTime()})";

            // execute
            var result = await _client.Update(Contact);
            //var result = await _client.Contact.Update(Contact);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Contact;
        }

        private async Task<Contact> CloneContact(Contact Contact)
        {
            Contact.DisplayName = $"TEST Clone Name:({GetCurrentTime()})";

            // Commands
            var result = await _client.Clone(Contact);
            //var result = await _client.Contact.Clone(Contact);

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

        private async Task<Contact> DeleteContactBulk(Contact Contact)
        {
            Contact bulk = new()
            {
                SelectedIDs = new List<long> { (long)Contact.ID },
                DeleteAssociatedContactsDeals = true
            };

            // Commands
            var result = await _client.DeleteBulk(bulk);
            //var result = await _client.Contact.DeleteBulk(bulk);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            Assert.Null(result.Includes);
            return GetResponse(result) as Contact;
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

        /// <summary>
        /// 
        /// </summary>

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
