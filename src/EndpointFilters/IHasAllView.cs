using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.EndpointFilters
{
    public interface IHasAllView<T>
    {
        public Meta Meta { get; set; }

        List<T> Items { get; set; }
    }
}
