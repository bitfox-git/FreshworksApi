[![nuget badge](https://img.shields.io/nuget/v/Bitfox.Freshworks.svg)](https://www.nuget.org/packages/Bitfox.Freshworks/)

# Freshworks Client  
Install [Nuget Package](https://www.nuget.org/packages/Bitfox.Freshworks/) into your project.  
Than login into your [freshworks](https://www.freshworks.com/crm/login/) domain and get your `Api-Key` from:   
`https://<Your Freshwork Domain>.myfreshworks.com/crm/sales/personal-settings/api-settings`

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
// get owner
var result = await _client.GetOwners();
var owner = result.Value.Users[0];

// create account on owner
var account = new Account();
account.Name = "Account name";
account.OwnerID = owner.ID;

var output = await _client.Insert(account);
```

`UPDATE`:
```csharp
account.Name = "Updated Account name";

var output = await _client.Update(account);
```

`GET`:
```csharp
var output = await _client.GetByID(account);
```

`DELETE`:
```csharp
var output = await _client.Delete(account);
```

`<returns>`:  
`output.Error` = Error message when something goes wrong.  
`output.Value` = A single Value as response.  
`output.Values`= A List of values as response.  

Check for more samples on this [Page](./Samples.md)  
For ways of binding the `FreshworksApi` to the application check this [File](./Samples_Binding.md).  
Any error or wrong behaviour please leave a issue, Thanks.


