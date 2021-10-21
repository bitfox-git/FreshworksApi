using Bitfox.Freshworks.Endpoints.Appointment;
using Bitfox.Freshworks.Endpoints.Selector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Bitfox.Freshworks.Tests
{

    [Collection("Client Collection")]
    public class UnitTestAppointment
    {
        private readonly ICRMClient _client;

        public UnitTestAppointment(ClientFixture clientFixture)
        {
            _client = clientFixture.Client;
        }

        [Fact]
        public async Task InsertTaskOnSuccess()
        {
            Appointment appointment = await CreateAppointment();

            _ = await RemoveAppointment(appointment.Item);
        }

        [Fact]
        public async Task GetTaskByIDOnSuccess()
        {
            Appointment appointment =  await GetAppointmentByID();

            _ = await RemoveAppointment(appointment.Item);
        }

        [Fact]
        public async Task GetTaskByIDAndIncludesOnSuccess()
        {
            Appointment appointment =  await GetAppointmentByIDAndSelectors();

            _ = await RemoveAppointment(appointment.Item);
        }

        [Fact]
        public async Task GetAllTasksByFilterOnSuccess()
        {
            _ = await GetAllTasksByFilter();
        }

        [Fact]
        public async Task UpdateTaskOnSuccess()
        {
            Appointment appointment =  await CreateAppointment();

            appointment =  await UpdateTask(appointment.Item);

            _ = await RemoveAppointment(appointment.Item);
        }

        [Fact]
        public async Task DeleteTaskOnSuccess()
        {
            // get Tasks
            Appointment appointment =  await CreateAppointment();

            _ = await RemoveAppointment(appointment.Item);
        }

        private async Task<Appointment> CreateAppointment()
        {
            Appointment appointment = new()
            {
                Title = "(Sample) Send the a content",
                FromDate = "2021-10-11T05:30:19-04:00",
                EndDate = "2021-10-11T05:30:19-04:00"
            };

            // execute creation
            var result = await _client.Insert(appointment);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as Appointment;
        }

        private async Task<Appointment> RemoveAppointment(Appointment task)
        {
            // execute
            var result = await _client.Delete(task, hasBodyOnResponse: true);
            //var result = await _client.Tasks.Delete(task, hasBodyOnResponse:true);
            //var result = await _client.Delete<Tasks>(task.ID, hasBodyOnResponse:true);
            //var result = await _client.Tasks.Delete<Tasks>(task.ID, hasBodyOnResponse:true);

            Assert.NotNull(result.Content);
            Assert.Null(result.Error);
            return result.Content as Appointment;
        }

        private async Task<Appointment> GetAppointmentByID()
        {
            var appointment =  await CreateAppointment();

            // exucute get Tasks
            var result = await _client.Query().GetByID(appointment.Item);
            //var result = await _client.Query().GetByID<Appointment>(appointment.Item.ID);
            //var result = await _client.Appointment.Query().GetByID(appointment.Item);
            //var result = await _client.Appointment.Query().GetByID<Appointment>(appointment.Item.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as Appointment;
        }

        private async Task<Appointment> GetAppointmentByIDAndSelectors()
        {
            // create Tasks
            var content = await CreateAppointment();
            Appointment appointment = new() { ID = content.Item.ID };

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
                .GetByID(appointment);
            //var result = await _client.Query().Include("owner").GetByID<Appointment>(appointment.Item.ID);
            //var result = await _client.Appointment.Query().Include("owner").GetByID(appointment);
            //var result = await _client.Appointment.Query().Include("owner").GetByID<Appointment>(appointment.Item.ID);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as Appointment;
        }

        private async Task<Appointment> GetAllTasksByFilter()
        {
            // execute
            var result = await _client.Query().GetAllByFilter<Appointment>("upcoming");

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as Appointment;
        }

        private async Task<Appointment> UpdateTask(Appointment task)
        {
            Appointment newAppointment =  new()
            {
                ID = task.ID,
                Title = $"New title content"
            };

            // execute
            var result = await _client.Update(newAppointment);
            //var result = await _client.Appointment.Update(newAppointment);

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
            return result.Content as Appointment;
        }

    }
}
