using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.Selectors;

namespace Bitfox.Freshworks
{
    public class CRMClient : ICRMClient
    {
        private readonly string subdomain;
        private readonly string apikey;

        public string BaseURL
        {
            get
            {
                return $"https://{subdomain}.myfreshworks.com/crm/sales";
            }
        }

        public SelectorController Selector => new(BaseURL, apikey);

        public IContactController Contact => new ContactController(BaseURL, apikey);

        public IAccountController Account => new AccountController(BaseURL, apikey);

        public IDealController Deal => new Controllers.DealController(BaseURL, apikey);

        public INoteController Note => new NoteController(BaseURL, apikey);

        public ITaskController Task => new TaskController(BaseURL, apikey);

        public IAppointmentController Appointment => new AppointmentController(BaseURL, apikey);

        public ISalesController Sales => new SalesController(BaseURL, apikey);

        // TODO
        // public SearchEndpoints Search => new(BaseURL, apikey);

        public IPhoneController Phone => new PhoneController(BaseURL, apikey);

        public IFileController File => new FileController(BaseURL, apikey);

        internal CRMClient(string subdomain, string apikey)
        {
            this.subdomain = subdomain;
            this.apikey = apikey;
        }
    }
}
