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
        public WeatherForecastController(ICRMClient client)
        {
            //client.Contact.
            //var account = client.Query<SalesAccount>();
            //var response = account.GetAll();



            //Console.WriteLine(response);



            //client.GetTest();
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return null;
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}
