using Bitfox.Freshworks.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Result<TEntity> where TEntity: IResult
    {
        public object Content { get; set; }

        public Includes Includes { get; set; } = new();

        public Errors Error { get; set; } = null;

        public Result(string content)
        {
            TEntity body = JsonConvert.DeserializeObject<TEntity>(content);

            // set Error
            if (body.Error != null)
            {
                Error = body.Error;
            }
            // set Content
            else if (!IsEmpty(body))
            {
                SetContent(body);

                // Add includes
                _ = Includes.Update<TEntity>(content);
            }

            if(Includes.IsEmpty())
            {
                Includes = null;
            }
        }

        private void SetContent(TEntity body)
        {
            List<object> objects = new();

            foreach (PropertyInfo prop in typeof(TEntity).GetProperties())
            {
                foreach (object attr in prop.GetCustomAttributes(true))
                {
                    if (attr.GetType() == typeof(JsonParentPropertyAttribute))
                    {
                        var obj = prop.GetValue(body);
                        if(obj != null)
                        {
                            objects.Add(obj);
                        }
                    }
                }
            }

            if (objects.Count > 1)
            {
                Content = objects;
            }
            else
            {
                Content = objects[0];
            }
        }

        private static bool IsEmpty(TEntity obj)
        {
            var values = obj.GetType()
                     .GetProperties()
                     .Where(field => field.GetValue(obj) != null)
                     .ToList();

            return (values.Count == 0);
        }
    
    }
}
