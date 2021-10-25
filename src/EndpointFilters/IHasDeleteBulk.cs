using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public interface IHasDeleteBulk
    {
        List<long> SelectedIDs { get; set; }

        bool? DeleteAssociatedContactDeals { get; set; }

        //void CatchDeleteBulkExceptions();


    }
}
