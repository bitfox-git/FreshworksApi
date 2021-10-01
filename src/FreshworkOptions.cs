using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class FreshworkOptions
    {
        public const string Position = "FreshworkOptions";

        public string Domain { get; set; }
        public string ApiKey { get; set; }
    }
}
