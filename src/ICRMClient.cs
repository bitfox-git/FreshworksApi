using Bitfox.Freshworks.Controllers;
using Bitfox.Freshworks.Endpoints.Selector;
using Bitfox.Freshworks.Models;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    public interface ICRMClient
    {
        /// <summary>
        /// Handles data based on subdomain. [ Query ]
        /// </summary>
        ISelectorController Selector { get; }

        /// <summary>
        /// Handles Contacts Actions. [Insert, Update, Delete etc.]
        /// </summary>
        IContactController Contact { get; }

        /// <summary>
        /// Handles Account Actions. [Insert, Update, Delete etc.]
        /// </summary>
        IAccountController Account { get; }

        /// <summary>
        /// Handles Deals Actions. [Insert, Update, Delete etc.]
        /// </summary>
        IDealController Deal { get; }

        /// <summary>
        /// Handles Notes Actions. [Insert, Update, Delete etc.]
        /// </summary>
        INoteController Note { get; }

        /// <summary>
        /// Handles Tasks Actions. [Insert, Update, Delete etc.]
        /// </summary>
        ITaskController Task { get; }

        /// <summary>
        /// Handles Appointment Actions. [Insert, Update, Delete etc.]
        /// </summary>
        IAppointmentController Appointment { get; }

        /// <summary>
        /// Handles Appointment Actions. [Insert, Update, Delete etc.]
        /// </summary>
        ISaleController Sale { get; }

        /// <summary>
        /// Query data from database. [ GET ]
        /// </summary>
        Query Query();

        /// <summary>
        /// Get all panel data. [ GET ]
        /// </summary>
        /// <typeparam name="TEntity">Type of fetch</typeparam>
        Task<Result<TEntity>> FetchAll<TEntity>() where TEntity : IHasFilters;

        /// <summary>
        /// Insert item into database.
        /// </summary>
        /// <typeparam name="T">Type of item and response</typeparam>
        /// <param name="item">Item that needs to insert</param>
        Task<Result<T>> Insert<T>(T item) where T : IHasInsert;

        /// <summary>
        /// Update item that contains in database.
        /// </summary>
        /// <typeparam name="T">Type of item and response</typeparam>
        /// <param name="item">Item that needs to been updated</param>
        Task<Result<T>> Update<T>(T item) where T : IHasUpdate;
        
        /// <summary>
        /// Clone item that contains in database with new credentials
        /// </summary>
        /// <typeparam name="T">Type of item and response</typeparam>
        /// <param name="item">Item that needs to been Cloned from</param>
        Task<Result<T>> Clone<T>(T item) where T : IHasClone;
        
        /// <summary>
        /// Delete item that contains in database.
        /// </summary>
        /// <typeparam name="T">Type of item and response</typeparam>
        /// <param name="item">Item that needs to been deleted</param>
        Task<Result<bool>> Delete<T>(T item) where T : IHasDelete;
        Task<Result<T>> Delete<T>(T item, bool hasBodyOnResponse) where T : IHasDelete;
        
        /// <summary>
        /// Delete item that contains in database.
        /// </summary>
        /// <typeparam name="T">Type of item and response</typeparam>
        /// <param name="id">Long id that needs to been deleted</param>
        Task<Result<bool>> Delete<T>(long? id) where T : IHasDelete;

        /// <summary>
        /// Forget item that contains in database.
        /// </summary>
        /// <typeparam name="T">Type of item and response</typeparam>
        /// <param name="item">Item that needs to been Forgotten</param>
        Task<Result<bool>> Forget<T>(T item) where T : IHasForget;

        /// <summary>
        /// Forget item that contains in database.
        /// </summary>
        /// <typeparam name="T">Type of item and response</typeparam>
        /// <param name="id">Long id that needs to been Forgotten</param>
        Task<Result<bool>> Forget<T>(long? id) where T : IHasForget;

        /// <summary>
        /// Assign a bulk of items to the database.
        /// </summary>
        /// <typeparam name="T">Type of item and response</typeparam>
        /// <param name="item">Item that needs to been Assigning a bulk</param>
        Task<Result<T>> AssignBulk<T>(T item) where T : IHasAssignBulk;

        /// <summary>
        /// Delete a bulk of items from the database.
        /// </summary>
        /// <typeparam name="T">Type of item and response</typeparam>
        /// <param name="item">Item that needs to been Deleting a bulk</param>
        Task<Result<T>> DeleteBulk<T>(T item) where T : IHasDeleteBulk;
    }
}
