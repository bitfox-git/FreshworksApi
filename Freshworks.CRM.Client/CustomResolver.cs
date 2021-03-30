using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Reflection;

namespace Freshworks.CRM.Client.Models
{
    public class CustomResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty prop = base.CreateProperty(member, memberSerialization);

            if (member.GetCustomAttribute<JsonPropertyNameBasedOnSingularNameOfT>() != null)
            {
                Type itemType = prop.PropertyType;
                JsonSingularNameAttribute att = itemType.GetCustomAttribute<JsonSingularNameAttribute>();
                if (att!=null) {
                    prop.PropertyName = att.SingularName;
                }
                //prop.PropertyName = att != null ? att.SingularName : itemType.Name;
            }

            if (member.GetCustomAttribute<JsonPropertyNameBasedOnPluralNameOfT>() != null)
            {
                Type itemType = prop.PropertyType;
                Type T = itemType;

                //List<T>
                if (itemType.IsGenericType)
                {
                    T= itemType.GenericTypeArguments[0];
                }
                //T[] 
                if (itemType.IsArray)
                {
                    T = itemType.GetElementType();
                }

                //

                JsonPluralNameAttribute att = T.GetCustomAttribute<JsonPluralNameAttribute>();
                if (att != null)
                {
                    prop.PropertyName = att.PluralName;
                }
                //prop.PropertyName = att != null ? att.SingularName : itemType.Name;
            }

            return prop;
        }
    }

 

}
