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
        /// Handles Account Actions. [Insert, Update, Delete etc.]
        /// </summary>
        IAccountController Account { get; }

        Task<T> Insert<T>(T item) where T: IHasInsert;

        Task<T> Update<T>(T item) where T : IHasUpdate;

        Task<T> Clone<T>(T item) where T : IHasClone;

        Query<T> Query<T>() where T : IHasView, IResult;

        Task<bool> Delete<T>(T item) where T : IHasDelete;

        Task<bool> Delete<T>(long? id);

        Task<T> DeleteBulk<T>(T item) where T : IHasDeleteBulk;

        //Task<T> Forget<T>(T item) where T : IHasForget;

        //Task<T> Forget<T>(long? id);



        //IAccountController Account { get; }


        //Task<T> GetView<T>(long id) where T : IHasView;

        //Task<T> GetView<T>(T item) where T : IHasView, IHasUniqueID;

        //Task<T> GetAllByID<T>(T item) where T : IHasView, IHasUniqueID;

        //Task<T> GetAllByID<T>(long id) where T : IHasView;

        //Task<T> UpdateView<T>(T item) where T : IHasUpdate, IHasUniqueID;




        ///// <summary>
        ///// Get data from the user portal.
        ///// </summary>
        //SelectorController Selector { get; }

        ///// <summary>
        ///// Handles Contact Actions. [Insert, Update, Delete etc.]
        ///// </summary>
        //IContactController Contact { get; }

        ///// <summary>
        ///// Handles Account Actions. [Insert, Update, Delete etc.]
        ///// </summary>
        //IAccountController Account { get; }

        ///// <summary>
        ///// Handles Deal Actions. [Insert, Update, Delete etc.]
        ///// </summary>
        //IDealController Deal { get; }

        ///// <summary>
        ///// Handles Note Actions. [Insert, Update, Delete etc.]
        ///// </summary>
        //INoteController Note { get; }

        ///// <summary>
        ///// Handles Task Actions. [Insert, Update, Delete etc.]
        ///// </summary>
        //ITaskController Task { get; }

        ///// <summary>
        ///// Handles Appointment Actions. [Insert, Update, Delete etc.]
        ///// </summary>
        //IAppointmentController Appointment { get; }

        ///// <summary>
        ///// Handles Sales Actions. [Insert, Update, Delete etc.]
        ///// </summary>
        //ISalesController Sales { get; }

        ///*
        //    /// <summary>
        //    /// // TODO
        //    /// Handles Search Actions. [Insert, Update, Delete etc.]
        //    /// </summary>
        //    SearchEndpoints Search { get; }
        //*/
        ///// <summary>
        ///// Handles Phone Actions. [Insert, Update, Delete etc.]
        ///// </summary>
        //IPhoneController Phone { get; }

        ///// <summary>
        ///// Handles File Actions. [Insert, Update, Delete etc.]
        ///// </summary>
        //IFileController File { get; }
    }
}
