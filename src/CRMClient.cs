using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.Endpoints.Sales;
using Bitfox.Freshworks.Endpoints.Selector;
using Bitfox.Freshworks.Models;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    public class CRMClient : Network, ICRMClient,
        IContactController,
        IAccountController,
        IDealController,
        INoteController,
        ITaskController,
        IAppointmentController,
        ISaleController
    {
        public ISelectorController Selector => Query();

        public IContactController Contact => this;

        public IAccountController Account => this;

        public IDealController Deal => this;

        public INoteController Note => this;

        public ITaskController Task => this;

        public IAppointmentController Appointment => this;

        public ISaleController Sale => this;

        internal CRMClient(string subdomain, string apikey): base($"https://{subdomain}.myfreshworks.com/crm/sales", apikey)
        { }

        public Query Query()
        {
            return new Query(BaseURL, ApiKey);
        }

        public async Task<Result<TEntity>> FetchAll<TEntity>() where TEntity : IHasFilters
        {
            string endpoint = $"{GetEndpoint<TEntity>()}/filters";
            return await GetApiRequest<TEntity>(endpoint, false);
        }

        public async Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert
        {
            body.CatchInsertExceptions();
            string endpoint = GetEndpoint<TEntity>();
            return await PostApiRequest(endpoint, body);
        }

        public async Task<Result<TEntity>> Update<TEntity>(TEntity body) where TEntity : IHasUpdate
        {
            body.CatchUpdateExceptions();
            string endpoint = $"{GetEndpoint<TEntity>()}/{body.ID}";
            return await UpdateApiRequest(endpoint, body);
        }

        public async Task<Result<TEntity>> Clone<TEntity>(TEntity body) where TEntity : IHasClone
        {
            body.CatchCloneExceptions();
            string endpoint = $"{GetEndpoint<TEntity>()}/{body.ID}/clone";
            return await PostApiRequest(endpoint, body);
        }

        public async Task<Result<bool>> Delete<TEntity>(long? id) where TEntity : IHasDelete
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is required for removing the view.");
            }

            string endpoint = $"{GetEndpoint<TEntity>()}/{id}";
            return await DeleteApiRequest(endpoint);
        }

        public async Task<Result<bool>> Delete<TEntity>(TEntity body) where TEntity : IHasDelete
        {
            body.CatchDeleteExceptions();
            string endpoint = $"{GetEndpoint<TEntity>()}/{body.ID}";
            return await DeleteApiRequest(endpoint);
        }

        public async Task<Result<bool>> Forget<TEntity>(long? id) where TEntity : IHasForget
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is required for removing the view.");
            }

            string endpoint = $"{GetEndpoint<TEntity>()}/{id}/forget";
            return await DeleteApiRequest(endpoint);
        }

        public async Task<Result<bool>> Forget<TEntity>(TEntity body) where TEntity : IHasForget
        {
            body.CatchForgetExceptions();
            string endpoint = $"{GetEndpoint<TEntity>()}/{body.ID}/forget";
            return await DeleteApiRequest(endpoint);
        }

        public async Task<Result<TEntity>> AssignBulk<TEntity>(TEntity body) where TEntity : IHasAssignBulk
        {
            body.CatchAssignBulkExceptions();
            string endpoint = $"{GetEndpoint<TEntity>()}/bulk_assign_owner";
            return await PostApiRequest(endpoint, body);
        }

        public async Task<Result<TEntity>> DeleteBulk<TEntity>(TEntity body) where TEntity : IHasDeleteBulk
        {
            body.CatchDeleteBulkExceptions();
            string endpoint = $"{GetEndpoint<TEntity>()}/bulk_destroy";
            return await PostApiRequest(endpoint, body);
        }

    }
}
