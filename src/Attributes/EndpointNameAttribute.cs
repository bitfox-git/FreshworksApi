using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bitfox.Freshworks.Attributes
{

    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class EndpointNameAttribute : Attribute
    {

        public string EndpointName { get; private set; }

        public EndpointNameAttribute(string name)
        {
            this.EndpointName = name;
        }

        public static string GetEndpointName<T>(T obj)
        {
            var myAttribute = GetAttribute(obj);
            if (myAttribute != null)
            {
                return myAttribute.EndpointName;
            }
            return null;
        }

        public static string GetEndpointNameOfType<T>()
        {
            var myAttribute = GetAttributeOfType<T>();
            if (myAttribute != null)
            {
                return myAttribute.EndpointName;
            }
            return null;
        }

        private static EndpointNameAttribute GetAttribute<T>(T obj)
        {
            return obj.GetType()
               .GetCustomAttributes(typeof(EndpointNameAttribute), true)
               .FirstOrDefault() as EndpointNameAttribute;
        }


        private static EndpointNameAttribute GetAttributeOfType<T>()
        {
            return typeof(T)
               .GetCustomAttributes(typeof(EndpointNameAttribute), true)
               .FirstOrDefault() as EndpointNameAttribute;
        }


    }
}
