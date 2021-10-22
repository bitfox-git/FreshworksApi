﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bitfox.Freshworks.Models
{
    public class Result<TEntity>
    {
        public TEntity Value { get; set; }

        public List<TEntity> Values { get; set; }

        [JsonProperty("errors")]
        public Error Error { get; set; } = null;

        public Result(string body)
        {
            if (!HandleError(body))
            {
                HandleBody(body);
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

        private void HandleBody(string fullBody)
        {
            try
            {
                var settings = new JsonSerializerSettings
                {
                    MissingMemberHandling = MissingMemberHandling.Error
                };

                if(fullBody.StartsWith("["))
                {
                    Values = JsonConvert.DeserializeObject<List<TEntity>>(fullBody, settings);
                }
                else
                {
                    Value = JsonConvert.DeserializeObject<TEntity>(fullBody, settings);
                }
            }
            catch (JsonSerializationException ex)
            {
                throw new JsonSerializationException(
                    $"{ex.Message}\n Failed on Value:\n" + fullBody
                );
            }
        }
    }
}
