using Bitfox.Freshworks.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Result<TEntity>
    {
        public object Content { get; set; }

        private TEntity Body { get; set; }

        public Includes Includes { get; set; } = new();

        [JsonProperty("errors")]
        public Error Error { get; set; } = null;

        public Result(string body, bool hasIncludes=false)
        {
            if (!HandleError(body))
            {
                HandleBody(body, hasIncludes);
            }
        }

        private bool HandleError(string body)
        {
            if (body == null) return true;

            var settings = new JsonSerializerSettings
            {
                Error = (se, ev) => { 
                    ev.ErrorContext.Handled = true; 
                }
            };
            var error = JsonConvert.DeserializeObject<Result<TEntity>>(body, settings);

            // error handling
            if (error != null && error.Error != null)
            {
                Error = error.Error;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void HandleBody(string fullBody, bool hasIncludes)
        {
            try
            {
                var settings = new JsonSerializerSettings
                {
                    MissingMemberHandling = MissingMemberHandling.Error
                };
                Body = JsonConvert.DeserializeObject<TEntity>(fullBody, settings);
            }
            catch (JsonSerializationException ex)
            {
                throw new JsonSerializationException(
                    $"{ex.Message}\n Failed on Content:\n" + fullBody
                );
            }


            if (HasBody())
            {
                SetBody();

                // Set response body to Includes
                if (hasIncludes)
                {
                    _ = Includes.Update<TEntity>(fullBody);
                }

                if (Includes.IsEmpty())
                {
                    Includes = null;
                } 
            }
            else
            {
                Content = Body;
            }
        }

        private bool HasBody()
        {
            var props = Body.GetType().GetProperties();

            // TEntity is `bool` for example
            if (props.Length == 0) return false;

            // TEntity has no values
            var propsValues = props
                     .Where(field => field.GetValue(Body) != null)
                     .ToList();

            return (propsValues.Count > 0);
        }

        private void SetBody()
        {
            List<object> objects = new();

            foreach (PropertyInfo prop in typeof(TEntity).GetProperties())
            {
                foreach (object attr in prop.GetCustomAttributes(true))
                {
                    if (attr is JsonReturnParentPropertyAttribute)
                    {
                        var obj = prop.GetValue(Body);
                        if (obj != null)
                        {
                            objects.Add(obj);
                        }
                    }
                }
            }

            if (objects.Count > 1)
            {
                Content = Body;
            }
            else if (objects.Count == 1)
            {
                Content = objects[0];
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    $"Do not contain JsonReturnParentPropertyAttribute in json model"
                );
            }
        }

    }
}
