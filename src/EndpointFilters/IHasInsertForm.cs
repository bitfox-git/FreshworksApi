using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.EndpointFilters
{
    public interface IHasInsertForm
    {
        string FilePath { get; set; }

        string NewFileName { get; set; }

        bool? IsShared { get; set; }

        long? TargetableID { get; set; }

        string TargetableType { get; set; }

        void CatchInsertFormExceptions();
    }
}
