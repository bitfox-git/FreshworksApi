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
    public class Result<TEntity>
    {
        public object Content { get; set; }

        public Includes Includes { get; set; } = new();

        [JsonProperty("errors")]
        public Errors Error { get; set; } = null;

        public Result(string content, bool hasIncludes=false)
        {
            if (content == null) return;

            Errors error = null;
            try
            {
                error = JsonConvert.DeserializeObject<Result<TEntity>>(content).Error;
            } 
            catch(Exception)
            { }
            
            // set Content
            if (error != null)
            {
                Error = error;
            }
            else
            {
                var body = JsonConvert.DeserializeObject<TEntity>(content);


                // TODO: has missing properties in TEntity


                if (!IsEmpty(body))
                {
                    SetContent(body);

                    // Add includes
                    if (hasIncludes)
                    {
                        _ = Includes.Update<TEntity>(content);
                    }
                }
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

            if (objects.Count == 0 || objects.Count > 1)
            {
                Content = body;
            }
            else
            {
                Content = objects[0];
            }
        }

        private static bool IsEmpty(TEntity obj)
        {
            var props = obj.GetType().GetProperties();

            // TEntity is `bool` for example
            if (props.Length == 0) return false;

            var values = props
                     .Where(field => field.GetValue(obj) != null)
                     .ToList();

            return (values.Count == 0);
        }
    
    }
}
