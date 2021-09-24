using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Selectors
{
    [EndpointName("industry_types")]
    public class IndustryTypes : ISelector
    {
        public List<IndustryType> industry_types { get; set; }
    }
}
