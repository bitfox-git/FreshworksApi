using Bitfox.Freshworks.NetworkModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Selectors
{
    public interface ISelectorController
    {

        /// <summary>
        /// Fetch all existing users' details in the Freshsales portal.  
        /// Will give id, name of the users
        /// </summary>
        /// <returns>List of all owners</returns>
        Task<UsersObject> GetOwners();


        /// <summary>
        /// Fetch all existing currency details in the Freshsales portal.
        /// Will give id, currency code and other details of currencies
        /// </summary>
        /// <returns>List of all currencies</returns>
        Task<CurrenciesObject> GetCurrencies();


        /// <summary>
        /// Fetch all existing business types' details in the Freshsales portal.
        /// Will give id, name of the business types
        /// </summary>
        /// <returns>List of all business types</returns>
        Task<BusinessTypesObject> GetBusinessTypes();


        /// <summary>
        /// Fetch all existing contact statuses' details in the Freshsales portal.
        /// Will give id, name of the contact statuses.
        /// </summary>
        /// <returns>List of all contact statuses</returns>
        Task<ContactStatusesObject> GetContactStatuses();


        /// <summary>
        /// Fetch all existing lifecycle_stages' details in the Freshsales portal.
        /// Will give id, name and contact statuses of the lifecycle stage.
        /// </summary>
        /// <returns>List of all lifecycle stages</returns>
        Task<LifecycleStagesObject> GetLifecycleStages();

        /// <summary>
        /// Fetch all existing industry types' details in the Freshsales portal.
        /// Will give id, name of the industry types
        /// </summary>
        /// <returns>List of all industry types</returns>
        Task<IndustryTypesObject> GetIndustryTypes();
    }
}
