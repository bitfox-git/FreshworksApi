using Bitfox.Freshworks.Models;
using Newtonsoft.Json;
using OfficeOpenXml;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    public class Result<TEntity>
    {
        public TEntity Value { get; set; }

        public List<TEntity> Values { get; set; }

        [JsonProperty("errors")]
        public Error Error { get; set; } = null;


        public Result() { }

        public Result(List<TEntity> values)
        {
            Values = values;
        }

        public Result(string respContent)
        {
            if (!HandleError(respContent))
            {
                HandleBody(respContent);
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
            }

            return (Error != null);
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
    
        public async Task<Result<TEntity>> SaveToExcel(string filename)
        {
            CatchExceptions();

            return await Excel.Write(filename, this);
        }

        private void CatchExceptions()
        {
            if (Error != null)
            {
                throw new InvalidDataException($"throw Error != null :{string.Join(", ", Error.Message)}");
            }
        }

    }
}
