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
        IAccount,
        IAppointment,
        IContact,
        IDeal,
        IFile,
        INote,
        IPhone,
        ISale,
        ISearch,
        ITask
    {
        public IAccount Account => this;

        public IAppointment Appointment => this;

        public IContact Contact => this;

        public IDeal Deal => this;

        public IFile File => this;

        public INote Note => this;

        public IPhone Phone => this;

        public ISale Sale => this;

        public ISearch Search => this;

        public ITask Task => this;

        public ISelector Selector => this;


        internal CRMClient(string subdomain, string apikey): base($"https://{subdomain}.myfreshworks.com/crm/sales", apikey)
        { }

        public async Task<Result<T>> FetchAll<T>() where T : IHasFilters
        {
            string endpoint = $"{GetEndpoint<T>()}/filters";
            return await GetApiRequest<T>(endpoint);
        }

        public async Task<Result<T>> Insert<T>(T body) where T : IHasInsert
        {
            body.CatchInsertExceptions();
            string endpoint = GetEndpoint<T>();
            return await PostApiRequest(endpoint, body);
        }

        public async Task<Result<T>> InsertForm<T>(T body) where T : IHasInsertForm
        {
            body.CatchInsertFormExceptions();
            string endpoint = GetEndpoint<T>();

            Dictionary<string, string> files = new();
            files.Add("file", body.FilePath);

            Dictionary<string, string> parameters = new();
            parameters.Add("file_name", body.NewFileName);
            parameters.Add("is_shared", body.IsShared.ToString());
            parameters.Add("targetable_id", body.TargetableID.ToString());
            parameters.Add("targetable_type", body.TargetableType.ToString());

            return await PostApiFormRequest<T>(endpoint, files, parameters);
        }

        public async Task<Result<T>> Update<T>(T body) where T : IHasUpdate
        {
            body.CatchUpdateExceptions();
            string endpoint = $"{GetEndpoint<T>()}/{body.ID}";
            return await UpdateApiRequest(endpoint, body);
        }

        public async Task<Result<T>> Clone<T>(T body) where T : IHasClone
        {
            body.CatchCloneExceptions();
            string endpoint = $"{GetEndpoint<T>()}/{body.ID}/clone";
            return await PostApiRequest(endpoint, body);
        }

        public async Task<Result<bool>> Delete<T>(long? id) where T : IHasDelete
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is required for removing the view.");
            }

            string endpoint = $"{GetEndpoint<T>()}/{id}";
            return await DeleteApiRequest(endpoint);
        }

        public async Task<Result<bool>> Delete<T>(T body) where T : IHasDelete
        {
            body.CatchDeleteExceptions();
            string endpoint = $"{GetEndpoint<T>()}/{body.ID}";
            return await DeleteApiRequest(endpoint);
        }

        public async Task<Result<T>> Delete<T>(T body, bool hasBodyAsResponse) where T : IHasDelete
        {
            body.CatchDeleteExceptions();
            string endpoint = $"{GetEndpoint<T>()}/{body.ID}";
            return await DeleteApiRequest<T>(endpoint);
        }

        public async Task<Result<bool>> Forget<T>(long? id) where T : IHasForget
        {
            if (id == null)
            {
                throw new ArgumentException($"ID is required for removing the view.");
            }

            string endpoint = $"{GetEndpoint<T>()}/{id}/forget";
            return await DeleteApiRequest(endpoint);
        }

        public async Task<Result<bool>> Forget<T>(T body) where T : IHasForget
        {
            body.CatchForgetExceptions();
            string endpoint = $"{GetEndpoint<T>()}/{body.ID}/forget";
            return await DeleteApiRequest(endpoint);
        }

        public async Task<Result<T>> AssignBulk<T>(T body) where T : IHasAssignBulk
        {
            body.CatchAssignBulkExceptions();
            string endpoint = $"{GetEndpoint<T>()}/bulk_assign_owner";
            return await PostApiRequest(endpoint, body);
        }

        public async Task<Result<T>> DeleteBulk<T>(T body) where T : IHasDeleteBulk
        {
            body.CatchDeleteBulkExceptions();
            string endpoint = $"{GetEndpoint<T>()}/bulk_destroy";
            return await PostApiRequest(endpoint, body);
        }

    }
}
