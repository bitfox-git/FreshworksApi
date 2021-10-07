using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Selectors
{
    public class SelectorController: BaseController, ISelectorController
    {
        public SelectorController(string baseURL, string apikey): base($"{baseURL}/api/selector", apikey)
        { }





    }
}
