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

        private ICRMClient Client;

        public WeatherForecastController(ICRMClient client)
        {
            Client = client;
        }

        public IActionResult Get()
        {

            //Sale sale = new()
            //{
            //    Name="account"
            //};

            //Account account = new()
            //{
            //    Name = "niek asdasda"
            //};

            //Client.Insert(account);




            return Ok();
        }
    }
}
