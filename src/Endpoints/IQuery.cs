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
        IQuery Include(string include);

        Task<Result<T>> GetByID<T>(T body) where T : IHasView, IHasUniqueID;

        Task<Result<T>> GetByID<T>(long? id) where T : IHasView;

        Task<Result<T>> GetAllByID<T>(T body) where T : IHasAllView, IHasUniqueID;

        Task<Result<T>> GetAllByID<T>(long? id) where T : IHasAllView;

        Task<Result<T>> GetAllByFilter<T>(string filter) where T : IHasView;

        Task<Result<T>> GetAllFileAndLinks<T>(T body) where T: IHasFileAndLinks;

        Task<Result<T>> GetAllFileAndLinks<T>(long? id) where T : IHasFileAndLinks;

        Task<Result<T>> GetAllActivitiesByID<T>(T body) where T : IHasActivities, IHasUniqueID;

        Task<Result<T>> GetAllActivitiesByID<T>(long? id) where T : IHasActivities;

        Task<Result<T>> GetAllFields<T>() where T : IHasFields;


    }
}
