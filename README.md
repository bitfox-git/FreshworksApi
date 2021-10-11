[![nuget badge](https://img.shields.io/nuget/v/Bitfox.Freshworks.svg)](https://www.nuget.org/packages/Bitfox.Freshworks/)

# Freshworks Client  
Samples and documentation for the `Bitfox.Freshworks`, a .NET 5.0 library for the Freshworks REST API.  

This repository contains the documentation and code samples for how to use Freshworks library NuGet package listed as `Bitfox.Freshworks`.

## Getting started  
1. Make sure to have a account on [freshworks](https://www.freshworks.com/crm/login/) 
2. Include the [Bitfox.Freshworks](./https://www.nuget.org/packages/Bitfox.Freshworks) Nuget package to your project.  
3. Capture your `<API Key>` from `https://<CRM Domain Name>.myfreshworks.com/crm/sales/personal-settings/api-settings`  
We need this key for configuration.

## Code snippets
### <b>Sample client in a Console application:</b>
``` C#
    static async Task Main(string[] args)
    {
        ICRMClient client = new CRMClientBuilder()
                            .SetSubdomain("<CRM Domain Name>")
                            .SetApiKey("<API Key>")
                            .Build();
        
        SelectorParent result = await client.Selector.GetOwners();
        Console.WriteLine(result);
    }
```

### <b>Sample client in a Web application:</b>
1. Add `services.AddFreshworks();` into `Startup.cs`, sample:
```C#
    public void ConfigureServices(IServiceCollection services)
    {
        // services.AddFreshworks((IConfiguration)Configuration); 
        // or
        services.AddFreshworks();
        services.AddControllers();
    }
```
2. Open `appsettings.json` file and set the `<CRM Domain Name>` and `<API Key>`, sample:
```json
{
    // ...

    "FreshworkOptions": {
        "Domain": "<CRM Domain Name>",
        "ApiKey": "<API Key>"
    }
}
```
3. Use it in Controllers, sample:
```C#
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ILogger Logger { get; set; }
        private ICRMClient Client { get; set; }

        public WeatherForecastController(ILogger logger, ICRMClient client)
        {
            Logger = logger;
            Client = client;
        }

        [HttpGet]
        public async Task<SelectorParent> Get()
        {
            return await Client.Selector.GetOwners();
        }
    }
```

### <b>Options</b>
You can as well add extra options to your request by adding the `Params` class to your request.
```C#
Params _params = new()
{
    Includes = new List<string>() { "users" },
    Page = 1,
    Limit = 3
};

var result = await Client.Selector.GetOwners(_params);
```
Where `Includes` option you can add different content to this response.  
1 `Page` means that you get a response off the items [0-25].  
3 `Limit` means a maximum limit of 3 items.

<!-- 
### <b>Data Filters included in Freshworks client</b>
Inside the Freshworks client we include extra filtering options on returned data. -->






