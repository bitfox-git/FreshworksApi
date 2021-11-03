using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Result<TEntity>
    {
        public TEntity Value { get; set; }

        public List<TEntity> Values { get; set; }

        [JsonProperty("errors")]
        public Error Error { get; set; } = null;

        public RestRequest Request { get; set; } = null;

        public Result(RestRequest request, string respContent)
        {
            Request = request;

            if (!HandleError(respContent))
            {
                HandleBody(respContent);



                //var filename = $"./Log_{nameof(TEntity)}_Results.json";

                //// Get content
                //var content = GetSavedContent(filename);
                //if(Value != null)
                //{
                //    content.Add(Value);
                //}
                //else
                //{
                //    content.AddRange(Values);
                //}
                //SetSavedContent(content, filename);
            }
            else
            {
                //var filename = $"./Log_{nameof(TEntity)}_Errors.json";

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
    
    
        private static List<TEntity> GetSavedContent(string filename)
        {
            var content = new List<TEntity>();
            if (System.IO.File.Exists(filename))
            {
                var json = System.IO.File.ReadAllText(filename);
                content = JsonConvert.DeserializeObject<List<TEntity>>(json);
            }

            return content;
        }

        private async Task UpdateCacheOnResponse(string filename)
        {
            // read content
            var content = new List<TEntity>();
            if (System.IO.File.Exists(filename))
            {
                var json = System.IO.File.ReadAllText(filename);
                content = JsonConvert.DeserializeObject<List<TEntity>>(json);
            }

            // add content
            if (Value != null)
            {
                content.Add(Value);
            }
            else if (Values != null)
            {
                content.AddRange(Values);
            }

            // write content
            var obj = JsonConvert.SerializeObject(content);
            await System.IO.File.WriteAllTextAsync(filename, obj);
        }

        private async Task UpdateCacheOnError(string filename)
        {
            // read content
            var content = new List<TEntity>();
            if (System.IO.File.Exists(filename))
            {
                var json = System.IO.File.ReadAllText(filename);
                content = JsonConvert.DeserializeObject<List<TEntity>>(json);
            }

            // add content
            if (Value != null)
            {
                content.Add(Value);
            }
            else if (Values != null)
            {
                content.AddRange(Values);
            }

            // write content
            var obj = JsonConvert.SerializeObject(content);
            await System.IO.File.WriteAllTextAsync(filename, obj);
        }

    }
}
