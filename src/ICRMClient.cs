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
        ContactEndpoints Contact { get; }

        /// <summary>
        /// Get data from the account portal.
        /// </summary>
        /// <returns>Portal data.</returns>
        AccountEndpoints Account { get; }

        /// <summary>
        /// Get data from the Deals portal.
        /// </summary>
        /// <returns>Portal data.</returns>
        DealEndpoints Deal { get; }

        /// <summary>
        /// Get data from the Deals portal.
        /// </summary>
        /// <returns>Portal data.</returns>
        TaskEndpoints Task { get; }


        /// <summary>
        /// Get data from the Deals portal.
        /// </summary>
        /// <returns>Portal data.</returns>
        AppointmentEndpoints Appointment { get; }


        /// <summary>
        /// Get data from the Deals portal.
        /// </summary>
        /// <returns>Portal data.</returns>
        SalesEndpoints Sales { get; }





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
