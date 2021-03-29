using Freshworks.CRM.Client.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Freshworks.CRM.Client.Selectors
{


    [EndpointName("owners")]
    public class Owners : ISelector<User>
    { 
       

        public List<User> Users { get; set; }

        public List<User> Items => throw new NotImplementedException();
    }
}
