using Bitfox.Freshworks.NetworkModels;
using Bitfox.Freshworks.NetworkObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class AccountParent: ErrorObject, IAccountPayload
    {
        [JsonProperty("sales_account")]
        public AccountModel Account { get; set; } = null;

        [JsonProperty("sales_accounts")]
        public List<AccountModel> Accounts { get; set; } = null;

        [JsonProperty("meta")]
        public Meta Meta { get; set; } = null;

        [JsonProperty("field_groups")]
        public List<FieldGroup> FieldGroup { get; set; } = null;

        [JsonProperty("fields")]
        public List<Field> Fields { get; set; } = null;

        [JsonProperty("message")]
        public string Message { get; set; } = null;
    }
}
