using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.Selectors;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    public interface ICRMClient
    {
        /// <summary>
        /// Get data from the user portal.
        /// </summary>
        /// <returns>Portal data.</returns>
        Selection Selector { get; }

        /// <summary>
        /// Get data from the contact portal.
        /// </summary>
        /// <returns>Portal data.</returns>
        ContactPortal Contact { get; }

        /// <summary>
        /// Get data from the account portal.
        /// </summary>
        /// <returns>Portal data.</returns>
        AccountPortal Account { get; }





        //Get Get { get; }
        //Set Set { get; }
        //Post Post { get; }


        //Task<T> SelectorByID<T>(long id) where T : ISelector;

        Query<T> Query<T>() where T : IHasView;

        Task<Result<T>> Insert<T>(T value) where T : IUniqueID;

        Task<T> Update<T>(T value) where T : IUniqueID;

        Task<T> GetApiRequest<T>(string url);
    }
}
