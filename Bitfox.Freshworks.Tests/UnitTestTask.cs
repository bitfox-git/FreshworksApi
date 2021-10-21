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
    public class UnitTestTask
    {
        private readonly ICRMClient _client;

        public UnitTestTask(ClientFixture clientFixture)
        {
            _client = clientFixture.Client;
        }

        [Fact]
        public async Task InsertTaskOnSuccess()
        {
            TaskModel task = await CreateTask();

            _ = await RemoveTask(task.Item);
        }

        [Fact]
        public async Task GetTaskByIDOnSuccess()
        {
            TaskModel task = await GetTaskByID();

            _ = await RemoveTask(task.Item);
        }

        [Fact]
        public async Task GetTaskByIDAndIncludesOnSuccess()
        {
            TaskModel task = await GetTaskByIDAndSelectors();

            _ = await RemoveTask(task.Item);
        }

        [Fact]
        public async Task GetAllTasksByFilterOnSuccess()
        {
            _ = await GetAllTasksByFilter();
        }

        [Fact]
        public async Task UpdateTaskOnSuccess()
        {
            TaskModel task = await CreateTask();

            task = await UpdateTask(task.Item);

            _ = await RemoveTask(task.Item);
        }

        [Fact]
        public async Task UpdateTaskAsDoneOnSuccess()
        {
            TaskModel task = await CreateTask();

            task = await UpdateAsDoneTask(task.Item);

            _ = await RemoveTask(task.Item);
        }

        [Fact]
        public async Task DeleteTaskOnSuccess()
        {
            // get Tasks
            TaskModel task = await CreateTask();

            _ = await RemoveTask(task.Item);
        }

        private async Task<TaskModel> CreateTask()
        {
            var owners = await _client.Selector.GetOwners();
            var owner = (owners.Content as Selector).Users[0];

            TaskModel task = new()
            {
                Title = "(Sample) Send the a content",
                Description = "Send the proposal document and follow up with this contact after it.",
                CreatedAt = Convert.ToDateTime(DateTime.Now.ToString()),
                UpdatedAt = Convert.ToDateTime(DateTime.Now.ToString()),
                OwnerID = owner.ID,
                CreaterID = owner.ID,
                UpdaterID = owner.ID
            };

            // execute creation
            var result = await _client.Insert(task);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as TaskModel;
        }

        private async Task<TaskModel> RemoveTask(TaskModel task)
        {
            // execute
            var result = await _client.Delete(task, hasBodyOnResponse:true);
            //var result = await _client.Tasks.Delete(task, hasBodyOnResponse:true);
            //var result = await _client.Delete<Tasks>(task.ID, hasBodyOnResponse:true);
            //var result = await _client.Tasks.Delete<Tasks>(task.ID, hasBodyOnResponse:true);

            Assert.NotNull(result.Content);
            Assert.Null(result.Error);
            return result.Content as TaskModel;
        }

        private async Task<TaskModel> GetTaskByID()
        {
            var task = await CreateTask();

            // exucute get Tasks
            var result = await _client.Query().GetByID(task.Item);
            //var result = await _client.Query().GetByID<Tasks>(Tasks.Tasks.ID);
            //var result = await _client.Tasks.Query().GetByID(Tasks.Tasks);
            //var result = await _client.Tasks.Query().GetByID<Tasks>(Tasks.Tasks.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as TaskModel;
        }

        private async Task<TaskModel> GetTaskByIDAndSelectors()
        {
            // create Tasks
            var content = await CreateTask();
            TaskModel task = new() { ID = content.Item.ID };

            // exucute get Tasks
            var result = await _client.Query()
                .Include("owner")
                .Include("creater")
                .Include("updater")
                .Include("territory")
                .Include("business_type")
                .Include("tasks")
                .Include("appointments")
                .Include("Tasks")
                .Include("deals")
                .Include("industry_type")
                .Include("child_sales_Tasks")
                .GetByID(task);
            //var result = await _client.Query().Include("owner").GetByID<Tasks>(Tasks.ID);
            //var result = await _client.Tasks.Query().Include("owner").GetByID(Tasks);
            //var result = await _client.Tasks.Query().Include("owner").GetByID<Tasks>(Tasks.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as TaskModel;
        }

        private async Task<TaskModel> GetAllTasksByFilter()
        {
            // execute
            var result = await _client.Query().GetAllByFilter<TaskModel>("open");
            //var result = await _client.Query().GetAllByFilter<TaskModel>(content.ID);
            //var result = await _client.Tasks.Query().GetAllByFilter(content);
            //var result = await _client.Tasks.Query().GetAllByFilter<TaskModel>(content.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as TaskModel;
        }

        private async Task<TaskModel> UpdateTask(TaskModel task)
        {
            TaskModel newTask = new()
            {
                ID = task.ID,
                Title = $"New title content"
            };

            // execute
            var result = await _client.Update(newTask);
            //var result = await _client.Tasks.Update(newTask);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as TaskModel;
        }

        private async Task<TaskModel> UpdateAsDoneTask(TaskModel task)
        {
            TaskModel newTask = new()
            {
                ID = task.ID,
                Status = 1
            };

            // execute
            var result = await _client.Update(newTask);
            //var result = await _client.Tasks.Update(newTask);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as TaskModel;
        }
    }
}
