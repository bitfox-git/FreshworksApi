using System;

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
