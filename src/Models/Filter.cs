using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks.Models
{
    public class Filter
    {
        public long id { get; set; }
        public string name { get; set; }
        public string model_class_name { get; set; }
        public long user_id { get; set; }
        public bool is_default { get; set; }
        public DateTime updated_at { get; set; }
        public string user_name { get; set; }
           
    }
}
