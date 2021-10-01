using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    public interface ICRMClient
    {


        Query<T> Query<T>() where T : IHasView;

        Task<Result<T>> Insert<T>(T value) where T : IUniqueID;

        Task<T> Update<T>(T value) where T : IUniqueID;

         Task<T> GetApiRequest<T>(string url);

        
    }
}
