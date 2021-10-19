using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.Endpoints.Selector;
using Bitfox.Freshworks.Models;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    public class CRMClient : BaseController, ICRMClient,
        ISelectorController,
        IContactController,
        IAccountController,
        IDealController,
        INoteController,
        ITaskController,
        IAppointmentController,
        ISaleController
    {
        public ISelectorController Selector => this;

        public IContactController Contact => this;

        public IAccountController Account => this;

        public IDealController Deal => this;

        public INoteController Note => this;

        public ITaskController Task => this;

        public IAppointmentController Appointment => this;

        public ISaleController Sales => this;


        internal CRMClient(string subdomain, string apikey): base($"https://{subdomain}.myfreshworks.com/crm/sales", apikey)
        { }



        //public async Task<T> Insert<T>(T body) where T: IHasInsert
        //{
        //    string endpoint = GetEndpoint<T>();
        //    return await PostApiRequest(endpoint, body);
        //}

        //public async Task<T> GetView<T>(T item) where T : IHasView, IHasUniqueID
        //{
        //    return await GetView<T>((long)item.ID);
        //}

        //public async Task<T> GetView<T>(long id) where T: IHasView
        //{
        //    string endpoint = $"{GetEndpoint<T>()}/{id}";
        //    return await GetApiRequest<T>(endpoint);
        //}

        //public async Task<T> GetAllByID<T>(T item) where T : IHasView, IHasUniqueID
        //{
        //    return await GetAllByID<T>((long)item.ID);
        //}

        //public async Task<T> GetAllByID<T>(long id) where T : IHasView
        //{
        //    string endpoint = $"{GetEndpoint<T>()}/view/{id}";
        //    return await GetApiRequest<T>(endpoint);
        //}

        //public async Task<T> UpdateView<T>(T item) where T : IHasUpdate, IHasUniqueID
        //{
        //    string endpoint = $"{GetEndpoint<T>()}/{item.ID}";
        //    return await UpdateApiRequest<T>(endpoint, item);
        //}

        //public Query<T> Query<T>()// where T : IHasView
        //{
        //    return new Query<T>(BaseURL, ApiKey);
        //}



        //public SelectorController Selector => new(BaseURL, apikey);

        //public IContactController Contact => new ContactController(BaseURL, apikey);


        //public IDealController Deal => new Controllers.DealController(BaseURL, apikey);

        //public INoteController Note => new NoteController(BaseURL, apikey);

        //public ITaskController Task => new TaskController(BaseURL, apikey);

        //public IAppointmentController Appointment => new AppointmentController(BaseURL, apikey);

        //public ISalesController Sales => new SalesController(BaseURL, apikey);

        //// TODO
        //// public SearchEndpoints Search => new(BaseURL, apikey);

        //public IPhoneController Phone => new PhoneController(BaseURL, apikey);

        //public IFileController File => new FileController(BaseURL, apikey);

        //internal CRMClient(string subdomain, string apikey)
        //{
        //    this.subdomain = subdomain;
        //    this.apikey = apikey;
        //}
    }
}
