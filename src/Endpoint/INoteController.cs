using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Endpoints.Note;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Controllers
{
    public interface INoteController
    {
        /// <summary>
        /// Insert a new note item.
        /// </summary>
        /// <param name="body">New note item payload</param>
        Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert;

        /// <summary>
        /// Update note information on note ID.
        /// </summary>
        /// <param name="body">Note ID and content used for update</param>
        Task<Result<TEntity>> Update<TEntity>(TEntity body) where TEntity : IHasUpdate;

        /// <summary>
        /// Remove note by note ID.
        /// </summary>
        /// <param name="body">Note ID</param>
        Task<Result<bool>> Delete<TEntity>(TEntity body) where TEntity : IHasDelete;

        /// <summary>
        /// Remove note by note ID.
        /// </summary>
        /// <param name="id">Note ID</param>
        Task<Result<bool>> Delete<TEntity>(long? id) where TEntity : IHasDelete;

    }
}
