using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class JsonSingularNameAttribute : Attribute
    {
        public string SingularName { get; set; }
        public JsonSingularNameAttribute(string singularName)
        {
            SingularName = singularName;
        }
    }
}
