
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class FreshworkConfiguration
    {
        public const string Name = "FreshworkOptions";

        public string Domain { get; set; }

        public string ApiKey { get; set; }

        public FreshworkConfiguration(IConfiguration configuration)
        {
            configuration.GetSection(Name).Bind(this);
        }
    }
}
