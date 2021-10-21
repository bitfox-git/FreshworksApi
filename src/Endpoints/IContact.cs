using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface IContact
    {
        /// <summary>
        /// Include data to this model.
        /// </summary>
        /// <param name="include">name of table</param>
        IQuery Include(string include);

        /// <summary>
        /// Insert a new contact item.
        /// </summary>
        /// <param name="body">New contact item payload</param>
        Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert;

        /// <summary>
        /// Get content from contact information.
        /// </summary>
        IQuery Query();

        /// <summary>
        /// Update contact information on contact ID.
        /// </summary>
        /// <param name="body">Contact ID and contact used for update</param>
        Task<Result<TEntity>> Update<TEntity>(TEntity body) where TEntity : IHasUpdate;

        /// <summary>
        /// Clone a contact by using his ID.
        /// </summary>
        /// <param name="body">Contact ID and content used for cloning</param>
        Task<Result<TEntity>> Clone<TEntity>(TEntity body) where TEntity : IHasClone;

        /// <summary>
        /// Remove contact by contact ID.
        /// </summary>
        /// <param name="body">Contact ID</param>
        Task<Result<bool>> Delete<TEntity>(TEntity body) where TEntity : IHasDelete;

        /// <summary>
        /// Remove contact by contact ID.
        /// </summary>
        /// <param name="id">Contact ID</param>
        Task<Result<bool>> Delete<TEntity>(long? id) where TEntity : IHasDelete;

        /// <summary>
        /// Hard delete a contact and all the associated data.
        /// </summary>
        /// <param name="body">Contact contains ID that will been deleted</param>
        Task<Result<bool>> Forget<TEntity>(TEntity body) where TEntity : IHasForget;

        /// <summary>
        /// Hard delete a contact and all the associated data.
        /// </summary>
        /// <param name="id">ID that will been deleted</param>
        Task<Result<bool>> Forget<TEntity>(long? id) where TEntity : IHasForget;

        /// <summary>
        /// Assign contacts in bulk.
        /// </summary>
        /// <param name="body">Contact contains needed data for deletion</param>
        Task<Result<TEntity>> AssignBulk<TEntity>(TEntity body) where TEntity : IHasAssignBulk;

        /// <summary>
        /// Delete contacts in bulk.
        /// </summary>
        /// <param name="body">Contact contains needed data for deletion</param>
        Task<Result<TEntity>> DeleteBulk<TEntity>(TEntity body) where TEntity : IHasDeleteBulk;

    }
}
