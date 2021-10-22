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
    public class UnitTestNotes
    {
        private readonly ICRMClient _client;
        private readonly UnitTestSelectors _selectors;

        public UnitTestNotes(ITestOutputHelper console, ClientFixture clientFixture)
        {
            _client = clientFixture.Client;
            _selectors = new UnitTestSelectors(console, clientFixture);
        }

        [Fact]
        public async Task InsertNoteOnSuccess()
        {
            #region CreateAccount

            // get owner id
            var owners = await _selectors.GetOwners();
            var owner = owners[0];

            Account account = new()
            {
                Name = $"TEST INSERT Name:({GetCurrentTime()})",
                OwnerID = owner.ID
            };

            // execute creation
            var output = await _client.Insert(account);
            account = (output.Value as Account).Account;

            #endregion

            Note note = await CreateNote(account);

            _ = await RemoveNote(note.Item);
            _ = await _client.Delete(account);
        }

        [Fact]
        public async Task UpdateNoteOnSuccess()
        {
            #region CreateAccount

            // get owner id
            var owners = await _selectors.GetOwners();
            var owner = owners[0];

            Account account = new()
            {
                Name = $"TEST INSERT Name:({GetCurrentTime()})",
                OwnerID = owner.ID
            };

            // execute creation
            var output = await _client.Insert(account);
            account = (output.Value as Account).Account;

            #endregion

            Note note = await CreateNote(account);

            note = await UpdateNote(account, note.Item);

            _ = await RemoveNote(note.Item);
            _ = await _client.Delete(account);
        }

        [Fact]
        public async Task DeleteNoteOnSuccess()
        {
            #region CreateAccount

            // get owner id
            var owners = await _selectors.GetOwners();
            var owner = owners[0];

            Account account = new()
            {
                Name = $"TEST INSERT Name:({GetCurrentTime()})",
                OwnerID = owner.ID
            };

            // execute creation
            var output = await _client.Insert(account);
            account = (output.Value as Account).Account;

            #endregion

            // get Contact
            Note note = await CreateNote(account);

            _ = await RemoveNote(note.Item);
            _ = await _client.Delete(account);
        }

        public async Task<Note> CreateNote(Account account)
        {
            Note note = new()
            {
                Description = "Create Sample note for an account",
                TargetableType = "SalesAccount",
                TargetableID = account.ID
            };

            // execute creation
            var result = await _client.Insert(note);
            //var result = await _client.Note.Insert(note);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            return result.Value as Note;
        }

        public async Task<Note> UpdateNote(Account account, Note note)
        {
            Note update = new()
            {
                ID = note.ID,
                Description = "SalesAccount new Description",
                TargetableType = "SalesAccount",
                TargetableID = account.ID
            };

            // execute
            var result = await _client.Update(update);
            //var result = await _client.Note.Update(update);

            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            return result.Value as Note;
        }

        public async Task<Note> RemoveNote(Note note)
        {
            // execute
            var result = await _client.Delete<Note>(note, hasBodyOnResponse:true);
            //var result = await _client.Note.Delete(contact);
            //var result = await _client.Delete<Note>(note.ID);
            //var result = await _client.Note.Delete<Note>(note.ID);

            Assert.NotNull(result.Value);
            Assert.Null(result.Error);
            return result.Value as Note;
        }

        private static string GetCurrentTime()
        {
            return DateTime.Now.ToString();
        }
    
    }
}