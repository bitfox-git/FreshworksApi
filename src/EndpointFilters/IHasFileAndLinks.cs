using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.EndpointFilters
{
    public interface IHasFileAndLinks
    {
        long? ID { get; set; }

        List<File> Files { get; set; }

        List<FileLink> FileLinks { get; set; }

        List<FileAssociation> FileAssociations { get; set; }

        List<User> Users { get; set; }
    }
}
