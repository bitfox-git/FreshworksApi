using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Bitfox.Freshworks.Tests
{

    [Collection("Client Collection")]
    public class UnitTestSale
    {
        private readonly ICRMClient _client;

        public UnitTestSale(ClientFixture clientFixture)
        {
            _client = clientFixture.Client;
        }

        [Fact]
        public async Task InsertTaskOnSuccess()
        {
            var account = await CreateAccount();
            Sale sale = await CreateSale(account);

            _ = await RemoveSale(sale.Item);
        }

        [Fact]
        public async Task GetTaskByIDOnSuccess()
        {
            Sale sale = await GetSaleByID();

            _ = await RemoveSale(sale.Item);
        }

        [Fact]
        public async Task GetTaskByIDAndIncludesOnSuccess()
        {
            Sale sale = await GetSaleByIDAndSelectors();

            _ = await RemoveSale(sale.Item);
        }

        [Fact]
        public async Task GetAllTasksByFilterOnSuccess()
        {
            _ = await GetAllTasksByFilter();
        }

        [Fact]
        public async Task UpdateTaskOnSuccess()
        {
            var account = await CreateAccount();
            Sale sale = await CreateSale(account);

            sale = await UpdateTask(sale.Item);

            _ = await RemoveSale(sale.Item);
        }

        [Fact]
        public async Task DeleteTaskOnSuccess()
        {
            // get Tasks
            var account = await CreateAccount();
            Sale sale = await CreateSale(account);

            _ = await RemoveSale(sale.Item);
        }

        private async Task<Sale> CreateSale(Account account)
        {
            // get sales activity
            var types = await _client.Selector.GetSalesActivityTypes();
            var type = (types.Content as Selector).SalesTypes[0];

            Sale sale = new()
            {
                Title = "(Sample) Test",
                StartDate = Convert.ToDateTime(DateTime.Now.ToString()),
                EndDate = Convert.ToDateTime(DateTime.Now.ToString()),
                SalesActivityTypeID = type.ID,
                TargetableID = account.ID,
                TargetableType = "SalesAccount",
            };

            // execute creation
            var result = await _client.Insert(sale);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as Sale;
        }

        private async Task<Sale> RemoveSale(Sale task)
        {
            // execute
            var result = await _client.Delete(task, hasBodyOnResponse: true);
            //var result = await _client.Tasks.Delete(task, hasBodyOnResponse:true);
            //var result = await _client.Delete<Tasks>(task.ID, hasBodyOnResponse:true);
            //var result = await _client.Tasks.Delete<Tasks>(task.ID, hasBodyOnResponse:true);

            Assert.NotNull(result.Content);
            Assert.Null(result.Error);
            return result.Content as Sale;
        }

        private async Task<Sale> GetSaleByID()
        {
            var account = await CreateAccount();
            var sale = await CreateSale(account);

            // exucute get Tasks
            var result = await _client.Query().GetByID(sale.Item);
            //var result = await _client.Query().GetByID<Sale>(sale.Item.ID);
            //var result = await _client.Sale.Query().GetByID(sale.Item);
            //var result = await _client.Sale.Query().GetByID<Sale>(sale.Item.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as Sale;
        }

        private async Task<Sale> GetSaleByIDAndSelectors()
        {
            // create Tasks
            var account = await CreateAccount();
            var content = await CreateSale(account);
            Sale sale = new() { ID = content.Item.ID };

            // exucute get Tasks
            var result = await _client.Query()
                .Include("owner")
                .Include("creater")
                .Include("updater")
                .Include("territory")
                .Include("business_type")
                .Include("tasks")
                .Include("Sales")
                .Include("Tasks")
                .Include("deals")
                .Include("industry_type")
                .Include("child_sales_Tasks")
                .GetByID(sale);
            //var result = await _client.Query().Include("owner").GetByID<Sale>(sale.Item.ID);
            //var result = await _client.Sale.Query().Include("owner").GetByID(Sale);
            //var result = await _client.Sale.Query().Include("owner").GetByID<Sale>(sale.Item.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as Sale;
        }

        private async Task<Sale> GetAllTasksByFilter()
        {
            // execute
            var result = await _client.Query().GetAllByFilter<Sale>("upcoming");

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as Sale;
        }

        private async Task<Sale> UpdateTask(Sale task)
        {
            Sale newSale = new()
            {
                ID = task.ID,
                Title = $"New title content"
            };

            // execute
            var result = await _client.Update(newSale);
            //var result = await _client.Sale.Update(newSale);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as Sale;
        }

        private async Task<Account> CreateAccount()
        {
            // get owner id
            var owners = await _client.Selector.GetOwners();
            var owner = (owners.Content as Selector).Users[0];

            Account acc = new()
            {
                Name = $"TEST INSERT Name:({DateTime.Now})",
                OwnerID = owner.ID
            };

            // execute creation
            var output = await _client.Insert(acc);
            return (output.Content as Account).Account;
        }

    }
}
