[![nuget badge](https://img.shields.io/nuget/v/Bitfox.Freshworks.svg)](https://www.nuget.org/packages/Bitfox.Freshworks/)

# Freshworks Client  
Goto [freshworks](https://www.freshworks.com/crm/login/) and login to `Your CRM Domain` . Than get your `Api-Key` from:   
`https://<Your CRM Domain>.myfreshworks.com/crm/sales/personal-settings/api-settings`

### Simple Usage
Made a connection to your crm domain:
```csharp
var _client = new CRMClientBuilder()
    .SetSubdomain("<Your CRM Domain>")
    .SetApiKey("<Api-Key>")
    .Build();
```

`INSERT`:
```csharp
// var output = await _client.Selector.GetOwners(id:123);
// var result = await _client.Query.GetOwners();
var result = await _client.GetOwners();
var owner = result.Value.Users[0];

var account = new Account();
account.Name = "Account name";
account.OwnerID = owner.ID;

// var output = await _client.Account.Insert(account);
var output = await _client.Insert(account);
```

`UPDATE`:
```csharp
account.Name = $"Updated Account name";

// var output = await _client.Account.Update(account);
var output = await _client.Update(account);
```

`GET`:
```csharp
// var output = await _client.Account.GetByID<Account>(id:123);
// var output = await _client.Account.GetByID(account);
// var output = await _client.GetByID<Account>(id:123);
var output = await _client.GetByID(account);
```

`DELETE`:
```csharp
// var output = await _client.Account.Delete<Account>(id:123);
// var output = await _client.Account.Delete(id:123);
// var output = await _client.Delete<Account>(id:123);
var output = await _client.Delete(account);
```

`<returns>`:  
`output.Error` = Error message when something goes wrong.  
`output.Value` = A single Value as response.  
`output.Values`= A List of values as response.  


When your are using a section, for example `_client.Account`, you only get the possible calls to this section.  
Any Error or miss behaviour please leave a issue, Thanks.

  
Kind Regards,

Niek Tuytel



