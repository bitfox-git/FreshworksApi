using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface IQuery: ISelector, ISearch
    {
        /// <summary>
        /// Set Tables that add on response 
        /// </summary>
        /// <param name="include">string that includes</param>
        /// <returns></returns>
        IQuery Include(string include);

        /// <summary>
        /// Get a single model
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="body">Model ID used to get the model</param>
        Task<Result<T>> GetByID<T>(T body) where T : IHasView, IHasUniqueID;

        /// <summary>
        /// Get a single model
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="id">Used to get the model</param>
        Task<Result<T>> GetByID<T>(long? id) where T : IHasView;

        /// <summary>
        /// Get all models
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="body">Model ID used to get the models</param>
        Task<Result<T>> GetAllByID<T>(T body) where T : IHasAllView, IHasUniqueID;

        /// <summary>
        /// Get all models
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="id">Used to get the models</param>
        Task<Result<T>> GetAllByID<T>(long? id) where T : IHasAllView;

        /// <summary>
        /// Get all models by filters
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="filter">Value to filter on.</param>
        Task<Result<T>> GetAllByFilter<T>(string filter) where T : IHasView;

        /// <summary>
        /// Get all Files and Links
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="body">Model ID to get data from.</param>
        Task<Result<T>> GetAllFileAndLinks<T>(T body) where T: IHasFileAndLinks;

        /// <summary>
        /// Get all Files and Links
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="id">ID to get data from</param>
        Task<Result<T>> GetAllFileAndLinks<T>(long? id) where T : IHasFileAndLinks;

        /// <summary>
        /// Get all Activities
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="body">Model ID to get data from.</param>
        Task<Result<T>> GetAllActivitiesByID<T>(T body) where T : IHasActivities, IHasUniqueID;

        /// <summary>
        /// Get all Activities
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        /// <param name="id">ID to get data from.</param>
        Task<Result<T>> GetAllActivitiesByID<T>(long? id) where T : IHasActivities;

        /// <summary>
        /// Get all Filters
        /// </summary>
        /// <typeparam name="T">Model data used in response</typeparam>
        Task<Result<T>> GetAllFields<T>() where T : IHasFields;

    }
}
