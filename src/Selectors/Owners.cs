using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Selectors
{


    [EndpointName("owners")]
    public class Owners : ISelector
    { 
       
        public List<User> Users { get; set; }

    }
}
