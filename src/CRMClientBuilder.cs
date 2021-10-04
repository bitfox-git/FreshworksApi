using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    /// <summary>
    /// Factory the get a ICRMClient instance.
    /// It uses a Fluent API pattern.
    /// </summary>
    public class CRMClientBuilder
    {
        private string subdomain;
        private string apikey;

        public CRMClientBuilder SetApiKey(string apikey)
        {
            this.apikey = apikey;
            return this;
        }

        public CRMClientBuilder SetSubdomain(string subdomain)
        {
            this.subdomain = subdomain;
            return this;
        }

        public ICRMClient Build()
        {
            return new CRMClient(subdomain, apikey);

        }

    }
}
