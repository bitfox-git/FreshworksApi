using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Attributes
{

    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class IncludeAttribute : Attribute
    {

        public string Include { get; private set; }

        public IncludeAttribute(string name)
        {
            this.Include = name;
        }

    }
}
