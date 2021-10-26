using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface ISale
    {
        /// <summary>
        /// Include data to this model.
        /// </summary>
        /// <param name="include">name of table</param>
        IQuery Include(string include);

        /// <summary>
        /// Add Filters to this model.
        /// </summary>
        /// <param name="include">name of table</param>
        Task<Result<T>> GetAllByFilter<T>(string filter) where T : IHasView;

        /// <summary>
        /// Get All sales items from the filters 
        /// </summary>
        /// <typeparam name="T">Sales class to get endpoint</typeparam>
        Task<Result<T>> FetchAll<T>() where T : IHasFilters;


        /// <summary>
        /// Insert a new Sale item.
        /// </summary>
        /// <param name="body">New appointment item payload</param>
        Task<Result<T>> Insert<T>(T body) where T : IHasInsert;

        /// <summary>
        /// Get A Sale on ID
        /// </summary>
        /// <typeparam name="T">Sale class get endpoint from</typeparam>
        /// <param name="body">New Sale payload</param>
        Task<Result<T>> GetByID<T>(T body) where T : IHasView, IHasUniqueID;

        /// <summary>
        /// Get A Sale on ID
        /// </summary>
        /// <typeparam name="T">Sale class get endpoint from</typeparam>
        /// <param name="id">Sale ID</param>
        Task<Result<T>> GetByID<T>(long id) where T : IHasView;

        /// <summary>
        /// Get All Sale on ID
        /// </summary>
        /// <typeparam name="T">Sale class get endpoint from</typeparam>
        /// <param name="body">New Sale payload</param>
        Task<Result<T>> GetAllByID<T>(T body) where T : IHasAllView<T>, IHasUniqueID;

        /// <summary>
        /// Get All Sale on ID
        /// </summary>
        /// <typeparam name="T">Sale class get endpoint from</typeparam>
        /// <param name="id">Sale ID</param>
        Task<Result<T>> GetAllByID<T>(long id) where T : IHasAllView<T>;


        /// <summary>
        /// Update Sales information on Sales ID.
        /// </summary>
        /// <param name="body">Sales ID and Sales used for update</param>
        Task<Result<T>> Update<T>(T body) where T : IHasUpdate;

        /// <summary>
        /// Remove Sales by Sales ID.
        /// </summary>
        /// <param name="body">Sales ID</param>
        Task<Result<bool>> Delete<T>(T body) where T : IHasDelete;

        /// <summary>
        /// Remove Sales by Sales ID.
        /// </summary>
        /// <param name="id">Sales ID</param>
        Task<Result<bool>> Delete<T>(long id) where T : IHasDelete;


    }
}
