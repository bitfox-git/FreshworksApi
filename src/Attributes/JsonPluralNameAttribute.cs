using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class JsonPluralNameAttribute : Attribute
    {
        public string PluralName { get; set; }
        public JsonPluralNameAttribute(string pluralName)
        {
            PluralName = pluralName;
        }
    }
}
