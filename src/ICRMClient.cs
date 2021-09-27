using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    public interface ICRMClient
    {


        Query<T> Query<T>() where T : IHasView;

        Task<T> GetApiRequest<T>(string url);

        
    }
}
