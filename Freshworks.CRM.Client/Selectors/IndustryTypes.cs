using Freshworks.CRM.Client.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Freshworks.CRM.Client.Selectors
{
    [EndpointName("industry_types")]
    public class IndustryTypes
    {
        public List<IndustryType> industry_types { get; set; }
    }
}
