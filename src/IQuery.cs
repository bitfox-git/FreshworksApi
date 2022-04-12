using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface IQuery: IQueryDefaults
    {




        /// <summary>
        /// Set Tables that add on response 
        /// </summary>
        /// <param name="include">string that includes</param>
        /// <returns></returns>
        IQuery Include(string include);

        Task<Result<T>> GetAllDeals<T>(long viewID) where T : IHasFilters, IHasAllView<T>, IHasDeals;

        Task<Result<T>> GetContactsLists<T>(long viewID) where T : IHasFilters, IHasAllView<T>, IHasContacts;

        Task<Result<T>> GetAll<T>() where T : IHasFilters, IHasAllView<T>;

        Task<Result<ListItem>> GetAllLists();

        //Task<List<Subscription>> GetAllSubscriptions();

        Task<Contact> AddList(Contact contact, string listName);

        Contact AddSubscription(Contact contact, long subscriptionType);

    }
}
