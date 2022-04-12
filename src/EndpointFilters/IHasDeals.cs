using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.EndpointFilters
{
    public interface IHasDeals
    {
        public List<DealEntity> deals { get; set; }
    }
}
