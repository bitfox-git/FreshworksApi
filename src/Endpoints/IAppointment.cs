﻿using Bitfox.Freshworks.Endpoints;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface IAppointment
    {
        /// <summary>
        /// Query data from database. [ GET ]
        /// </summary>
        IQuery Query { get; }

        /// <summary>
        /// Include data to this model.
        /// </summary>
        /// <param name="include">name of table</param>
        IQuery Include(string include);

        /// <summary>
        /// Insert a new Tasks item.
        /// </summary>
        /// <param name="body">New appointment item payload</param>
        Task<Result<TEntity>> Insert<TEntity>(TEntity body) where TEntity : IHasInsert;

        /// <summary>
        /// Update appointment information on appointment ID.
        /// </summary>
        /// <param name="body">Appointment ID and appointment used for update</param>
        Task<Result<TEntity>> Update<TEntity>(TEntity body) where TEntity : IHasUpdate;

        /// <summary>
        /// Remove appointment by appointment ID.
        /// </summary>
        /// <param name="body">Appointment ID</param>
        Task<Result<bool>> Delete<TEntity>(TEntity body) where TEntity : IHasDelete;

        /// <summary>
        /// Remove contact by contact ID.
        /// </summary>
        /// <param name="id">Contact ID</param>
        Task<Result<bool>> Delete<TEntity>(long? id) where TEntity : IHasDelete;
    }
}
