using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface IFile
    {
        /// <summary>
        /// Query data from database. [ GET ]
        /// </summary>
        IQuery Query { get; }

        /// <summary>
        /// Insert item into database.
        /// </summary>
        /// <typeparam name="T">Type of item and response</typeparam>
        /// <param name="item">Item that needs to insert</param>
        Task<Result<T>> InsertForm<T>(T item) where T : IHasInsertForm;

        /// <summary>
        /// Insert item into database.
        /// </summary>
        /// <typeparam name="T">Type of item and response</typeparam>
        /// <param name="item">Item that needs to insert</param>
        Task<Result<T>> Insert<T>(T item) where T : IHasInsert;

    }
}
