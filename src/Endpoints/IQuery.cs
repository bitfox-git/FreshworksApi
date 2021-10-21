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
        /// Include data to this model.
        /// </summary>
        /// <param name="include">name of table</param>
        IQuery Include(string include);

        Task<Result<TEntity>> GetByID<TEntity>(TEntity body) where TEntity : IHasView, IHasUniqueID;

        Task<Result<TEntity>> GetByID<TEntity>(long? id) where TEntity : IHasView;

        Task<Result<TEntity>> GetAllByID<TEntity>(TEntity body) where TEntity : IHasView, IHasUniqueID;

        Task<Result<TEntity>> GetAllByID<TEntity>(long? id) where TEntity : IHasView;

        Task<Result<TEntity>> GetAllByFilter<TEntity>(string filter) where TEntity : IHasView;

        Task<Result<TEntity>> GetAllActivitiesByID<TEntity>(TEntity body) where TEntity : IHasActivities, IHasUniqueID;

        Task<Result<TEntity>> GetAllActivitiesByID<TEntity>(long? id) where TEntity : IHasActivities;

        Task<Result<TEntity>> GetAllFields<TEntity>() where TEntity : IHasFields;



    }
}
