using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    public class CRMClient : Query, 
        ICRMClient,
        ISearch,
        IContact,
        IAccount,
        IDeal,
        INote,
        ITask,
        IAppointment,
        ISale,
        IPhone,
        IFile
    {

        public IQuery Query => this;

        public ISelector Selector => this;

        public ISearch Search => this;

        public IContact Contact => this;

        public IAccount Account => this;

        public IDeal Deal => this;

        public INote Note => this;

        public ITask Task => this;

        public IAppointment Appointment => this;

        public ISale Sale => this;

        public IPhone Phone => this;

        public IFile File => this;

        internal CRMClient(string subdomain, string apikey): base($"https://{subdomain}.myfreshworks.com/crm/sales", apikey)
        { }

        public async Task<Result<TEntity>> FetchAll<TEntity>() where TEntity : IHasFilters
        {
            string endpoint = $"{GetEndpoint<TEntity>()}/filters";
            return await GetApiRequest<TEntity>(endpoint);
        }

        public async Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert
        {
            body.CatchInsertExceptions();
            string endpoint = GetEndpoint<TEntity>();
            return await PostApiRequest(endpoint, body);
        }

        public async Task<Result<TEntity>> InsertForm<TEntity>(TEntity body) where TEntity : IHasInsertForm
        {
            body.CatchInsertFormExceptions();
            string endpoint = GetEndpoint<TEntity>();

            Dictionary<string, string> files = new();
            files.Add("file", body.FilePath);

            Dictionary<string, string> parameters = new();
            parameters.Add("file_name", body.NewFileName);
            parameters.Add("is_shared", body.IsShared.ToString());
            parameters.Add("targetable_id", body.TargetableID.ToString());
            parameters.Add("targetable_type", body.TargetableType.ToString());

            return await PostApiFormRequest<TEntity>(endpoint, files, parameters);
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

        public async Task<Result<TEntity>> Delete<TEntity>(TEntity body, bool hasBodyAsResponse) where TEntity : IHasDelete
        {
            body.CatchDeleteExceptions();
            string endpoint = $"{GetEndpoint<TEntity>()}/{body.ID}";
            return await DeleteApiRequest<TEntity>(endpoint);
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
