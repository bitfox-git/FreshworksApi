using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class IsRequiredOnAttribute: Attribute
    {
        public string Interface { get; set; }

        public IsRequiredOnAttribute(string type)
        {
            Interface = type;
        }

        public static void CatchExceptions(object classModel, string require)
        {
            List<string> values = new() { require };
            CatchExceptions(classModel, values);
        }

        public static void CatchExceptions(object classModel, List<string> required)
        {
            string message = "";

            PropertyInfo[] props = classModel.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                object[] attrs = prop.GetCustomAttributes(true);
                foreach (object attr in attrs)
                {
                    // Property with this attribute != null
                    if (attr is IsRequiredOnAttribute attribute)
                    {
                        string propName = prop.Name;
                        var propValue = prop.GetValue(classModel);

                        if (required.Contains(attribute.Interface))
                        {
                            message += $"Required key `{propName}` is missing.\n";
                        }
                    }
                }
            }

            if(message.Length > 0)
            {
                throw new MissingFieldException(message);
            }
        }
    }
}
