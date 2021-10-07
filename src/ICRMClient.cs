using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.NetworkObjects;
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
        SelectorController Selector { get; }

        /// <summary>
        /// Handles Contact Actions. [Create, Update, Delete etc.]
        /// </summary>
        IContactController Contact { get; }

        /// <summary>
        /// Handles Account Actions. [Create, Update, Delete etc.]
        /// </summary>
        IAccountController Account { get; }

        /// <summary>
        /// Handles Deal Actions. [Create, Update, Delete etc.]
        /// </summary>
        IDealController Deal { get; }

        /// <summary>
        /// Handles Note Actions. [Create, Update, Delete etc.]
        /// </summary>
        INoteController Note { get; }

        /// <summary>
        /// Handles Task Actions. [Create, Update, Delete etc.]
        /// </summary>
        ITaskController Task { get; }

        /// <summary>
        /// Handles Appointment Actions. [Create, Update, Delete etc.]
        /// </summary>
        IAppointmentController Appointment { get; }

        /// <summary>
        /// Handles Sales Actions. [Create, Update, Delete etc.]
        /// </summary>
        ISalesController Sales { get; }

        /*
            /// <summary>
            /// // TODO
            /// Handles Search Actions. [Create, Update, Delete etc.]
            /// </summary>
            SearchEndpoints Search { get; }
        */
        /// <summary>
        /// Handles Phone Actions. [Create, Update, Delete etc.]
        /// </summary>
        IPhoneController Phone { get; }

        /// <summary>
        /// Handles File Actions. [Create, Update, Delete etc.]
        /// </summary>
        IFileController File { get; }
    }
}
