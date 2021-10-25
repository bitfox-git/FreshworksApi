
## `Using in Web application:`
Add Freshworks service, Open `Startup.cs`:
```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddFreshworks(); // <--
    services.AddControllers();
}
```
Add Freshwork credentials, Open `appsettings.json`: (fill in your credentials)
```csharp
{
  "FreshworkOptions": {
    "Domain": "your freshworks domain",
    "ApiKey": "your freshworks api-key"
  }
}
```
In any Controller Constructor you can add `ICRMClient client`.

## `Using in Console application:`
```csharp
var client = new CRMClientBuilder()
    .SetSubdomain("<Your CRM Domain>")
    .SetApiKey("<Api-Key>")
    .Build();
```