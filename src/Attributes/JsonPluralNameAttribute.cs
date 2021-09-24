using System;

namespace Bitfox.Freshworks
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
