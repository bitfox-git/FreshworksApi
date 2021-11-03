using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Models;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    public interface ICRMClient: IQuery
    {
        /// <summary>
        /// Get all panel data. [ GET ]
        /// </summary>
        /// <typeparam name="T">Type of fetch</typeparam>
        Task<Result<T>> FetchAll<T>() where T : IHasFilters;

        /// <summary>
        /// Insert item into database.
        /// </summary>
        /// <typeparam name="T">Type of item and response</typeparam>
        /// <param name="item">Item that needs to insert</param>
        Task<Result<T>> Insert<T>(T item) where T : IHasInsert;

        /// <summary>
        /// Insert item into database.
        /// </summary>
        /// <typeparam name="T">Type of item and response</typeparam>
        /// <param name="body">Item that needs to insert</param>
        Task<Result<T>> InsertForm<T>(T body) where T : IHasInsertForm;

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
        Task<Result<bool>> Delete<T>(long id) where T : IHasDelete;

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
        Task<Result<bool>> Forget<T>(long id) where T : IHasForget;

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
