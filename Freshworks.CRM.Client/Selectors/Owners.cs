using Freshworks.CRM.Client.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Freshworks.CRM.Client.Selectors
{


    [EndpointName("owners")]
    public class Owners : ISelector
    { 
       
        public List<User> Users { get; set; }

    }
}
