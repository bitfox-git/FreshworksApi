using Bitfox.Freshworks;
using Bitfox.Freshworks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
/*<<<<<<< Updated upstream
        private ILogger Logger { get; set; }
        private ICRMClient Client { get; set; }

        public WeatherForecastController(ILogger logger, ICRMClient client)
        {
            Logger = logger;
=======
        public ICRMClient Client;s

        public WeatherForecastController(ICRMClient client)
        {
>>>>>>> Stashed changes
            Client = client;
        }

        [HttpGet]
<<<<<<< Updated upstream
        public async Task<SelectorParent> Get()
        {
            return await Client.Selector.GetOwners();
=======
        public async Task<SelectorParent> GetAsync()
        {
            var result = await Client.Selector.GetOwners();
            return result;
>>>>>>> Stashed changes
        }*/
    }
}
