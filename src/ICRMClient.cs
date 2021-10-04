using Bitfox.Freshworks.Models;
using Bitfox.Freshworks.Selectors;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    public interface ICRMClient
    {
        Task<T> Selector<T>() where T : ISelector;

        Task<T> SelectorByID<T>(long id) where T : ISelector;

        Query<T> Query<T>() where T : IHasView;

        Task<Result<T>> Insert<T>(T value) where T : IUniqueID;

        Task<T> Update<T>(T value) where T : IUniqueID;

        Task<T> GetApiRequest<T>(string url);
    }
}
