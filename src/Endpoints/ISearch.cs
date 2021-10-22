using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Endpoints
{
    public interface ISearch
    {
        IQuery Include(string include);

        /// <summary>
        /// Search in content what do actually match
        /// </summary>
        /// <param name="query">returning data contains this query</param>
        Task<Result<Search>> SearchOnQuery(string query);

        /// <summary>
        /// Get all content of TEntity from database, than filter data on SearchOnFilter model.
        /// </summary>
        /// <typeparam name="TEntity">Model you want to get data from</typeparam>
        /// <param name="body">The Value that you want to filter</param>
        Task<Result<SearchFilter>> SearchOnFilter<TEntity>(SearchFilter body) where TEntity : IHasFilteredSearch;

        /// <summary>
        /// Lookup in data with some filters specified.
        /// </summary>
        /// <param name="query">lookup for this string in models</param>
        /// <param name="field">data from given field ()</param>
        /// <param name="entities">entities to get data from</param>
        /// <returns></returns>
        Task<Result<SearchLookup>> SearchOnLookup(string query, string field, string entities);
    }
}
